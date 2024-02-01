using Library.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using Library.Entities;
using System.Text.RegularExpressions;



namespace UI
{
    public partial class ApplicationForm : Form
    {
        private readonly IApplicationLogicFacade applicationLogic;
        List<Label> ListClientLabels = new List<Label>();
        List<Client> clients = null;

        public ApplicationForm(IApplicationLogicFacade applicationLogic)
        {
            this.applicationLogic = applicationLogic;
            this.clients = (List<Client>)applicationLogic.GetAll();
            InitializeComponent();
            FillClientsPanel();
            FillPacketPanelByPacketType(PacketType.INTERNET, null);
            FillPacketPanelByPacketType(PacketType.TV, null);
            FillPacketPanelByPacketType(PacketType.COMBINED,null);
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            this.Text = "TIM 05 APPLICATION";
            ProviderNameLabel.Text = applicationLogic.GiveProviderName();
        }

        private void ProviderName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            string username;
            string FirstName;
            string LastName;

            if (!string.IsNullOrEmpty(UsernameTextBox.Text) && !string.IsNullOrEmpty(FirstNameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                username = UsernameTextBox.Text;
                FirstName = FirstNameTextBox.Text;
                LastName = LastNameTextBox.Text;
            }
            else
            {
                return;
            }

            Client client = new Client();
            client.Username = username;
            client.FirstName = FirstName;
            client.LastName = LastName;

            client = applicationLogic.AddClient(client);

            if (client == null)
                return;

            clients.Add(client);

            FillClientsPanel();
        }

        private void ClientLabel_Click(object sender, EventArgs e)
        {

        }

        public void FillClientsPanel()
        {
            ListClientLabels.Clear();
            ListOfClientsPanel.Controls.Clear();

            if (clients == null)
            {
                return;
            }

            foreach (Client client in clients)
            {
                Label label = new Label();
                label.Text = client.Username;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Tag = client.Id;
                label.Click += ClientClick;

                Button button = new Button();
                button.Image = new Bitmap("Properties/delete.jpg");
                button.Width = 21;
                button.Height = 21;
                button.Tag = client.Id;
                button.Click += DeleteClient;


                ListOfClientsPanel.Controls.Add(label);
                ListOfClientsPanel.Controls.Add(button);

                ListClientLabels.Add(label);
            }
        }

        private void ClientClick(object sender, EventArgs e)
        {
            foreach (var label in ListClientLabels)
            {
                label.BackColor = Color.Transparent;
            }

            Label clickedLabel = (Label)sender;
            long clientId = (long)clickedLabel.Tag;

            clickedLabel.BackColor = Color.LightGreen;

            Client client = null;

            foreach (var c in clients)
            {
                if (c.Id == clientId)
                    client = c;
            }
            
            NameValueLabel.Text = client.FirstName;
            SurnameValueLabel.Text = client.LastName;
            PriceToPayValue.Text = Convert.ToString(applicationLogic.GetPricesForIds(client.ListOfPackets));
            
            FillPacketPanelByPacketType(PacketType.TV, client);
            FillPacketPanelByPacketType(PacketType.INTERNET, client);
            FillPacketPanelByPacketType(PacketType.COMBINED, client);
        }

        public void FillPacketPanelByPacketType(PacketType type, Client client)
        {
            if (type == PacketType.TV)
            {
                ListOfTvPacketPanel.Controls.Clear();
            }
            else if (type == PacketType.INTERNET)
            {
                ListOfInternetPacketPanel.Controls.Clear();
            }
            else
            {
                ListOfCombinedPacketPanel.Controls.Clear();
            }

            IEnumerable<Packet> packets = applicationLogic.GetAllPacketByPacketType(type);

            if (packets == null)
                return;

            foreach (Packet packet in packets)
            {
                Label label = new Label();
                label.Width = 150;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = packet.Name + " | " + packet.Price;
                label.BorderStyle = BorderStyle.FixedSingle;
                //label.Tag = packet.Id;
                //label.Click += DeletePacketFunc;

                Button DeleteButton = null;
                Button AddButton = null;

                if (client != null && client.ListOfPackets.Contains(packet.Id))
                {
                    label.BackColor = Color.LightGreen;

                    DeleteButton = new Button();
                    DeleteButton.Image = new Bitmap("Properties/delete.jpg");
                    DeleteButton.Width = 21;
                    DeleteButton.Height = 21;
                    DeleteButton.Tag = new Tuple<Client, long>(client, packet.Id);
                    DeleteButton.Click += DeletePacketForClient;
                }
                else if (client != null && !client.ListOfPackets.Contains(packet.Id))
                {
                    AddButton = new Button();
                    AddButton.Image = new Bitmap("Properties/add.jpg");
                    AddButton.Width = 21;
                    AddButton.Height = 21;
                    AddButton.Tag = new Tuple<Client, long>(client, packet.Id);
                    AddButton.Click += AddPacketForClient;
                }

                if (type == PacketType.TV)
                {
                    ListOfTvPacketPanel.Controls.Add(label);
                    if (AddButton != null) ListOfTvPacketPanel.Controls.Add(AddButton);
                    if (DeleteButton != null) ListOfTvPacketPanel.Controls.Add(DeleteButton);
                }
                else if (type == PacketType.INTERNET)
                {
                    ListOfInternetPacketPanel.Controls.Add(label);
                    if (AddButton != null) ListOfInternetPacketPanel.Controls.Add(AddButton);
                    if (DeleteButton != null) ListOfInternetPacketPanel.Controls.Add(DeleteButton);
                }
                else
                {
                    ListOfCombinedPacketPanel.Controls.Add(label);
                    if (AddButton != null) ListOfCombinedPacketPanel.Controls.Add(AddButton);
                    if (DeleteButton != null) ListOfCombinedPacketPanel.Controls.Add(DeleteButton);
                }
            }

            if (client != null && client.Memento != null) 
            { 
                PriceToPayValue.Text = Convert.ToString(applicationLogic.GetPricesForIds(client.ListOfPackets));
                LastPriceToPayLabel.Text = Convert.ToString(applicationLogic.GetPricesForIds(client.Memento.listOfPackets));
            }
            else
                LastPriceToPayLabel.Text = "";
        }

        private void AddPacketForClient(object sender, EventArgs e)
        {
            if (sender is Button AddButton)
            {
                Tuple<Client, long> tagTuple = (Tuple<Client, long>)AddButton.Tag;
                Client client = tagTuple.Item1;
                long packetId = tagTuple.Item2;

                applicationLogic.AddPacketToClient(packetId, client.Id);

                //REFRESH

                FillPacketPanelByPacketType(PacketType.INTERNET, client);
                FillPacketPanelByPacketType(PacketType.TV, client);
                FillPacketPanelByPacketType(PacketType.COMBINED, client);

            }
        }

        private void DeletePacketForClient(object sender, EventArgs e)
        {
            if (sender is Button deleteButton)
            {
                Tuple<Client, long> tagTuple = (Tuple<Client, long>)deleteButton.Tag;
                Client client = tagTuple.Item1;
                long packetId = tagTuple.Item2;

                applicationLogic.RemovePacketFromClient(packetId, client.Id);

                //REFRESH

                FillPacketPanelByPacketType(PacketType.INTERNET, client);
                FillPacketPanelByPacketType(PacketType.TV, client);
                FillPacketPanelByPacketType(PacketType.COMBINED, client);

            }
        }

        private void DeleteClient(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Tag is long clientId)
                {
                    applicationLogic.DeleteClient(clientId);
                    clients = clients.Where(c => c.Id != clientId).ToList();
                    FillClientsPanel();

                    SurnameValueLabel.Text = "";
                    NameValueLabel.Text = "";
                    PriceToPayValue.Text = "";
                    LastPriceToPayLabel.Text = "";

                    FillPacketPanelByPacketType(PacketType.INTERNET,null);
                    FillPacketPanelByPacketType(PacketType.TV,null);
                    FillPacketPanelByPacketType(PacketType.COMBINED, null);
                }
            }
        }

        private void DeletePacketFunc(object sender, EventArgs e)
        {
            if(sender is Label button)
            {
                if(button.Tag is long packetId) 
                {
                    applicationLogic.DeletePacket(packetId);
                    FillPacketPanelByPacketType(PacketType.INTERNET, null);
                    FillPacketPanelByPacketType(PacketType.TV, null);
                    FillPacketPanelByPacketType(PacketType.COMBINED, null);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InternetPacketPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PacketName;
            double PacketPrice = -1;
            long NumberOfChannel = -1;
            double InternetSpeed = -1;

            string RegexPrice = @"^\d+(,\d{2})?$";
            string RegexNumber = @"\d+";

            if (!string.IsNullOrEmpty(PacketNameLabel.Text) && !string.IsNullOrEmpty(PacketNameLabel.Text))
            {
                PacketName = PacketNameLabel.Text;
                if(Regex.IsMatch(PacketPriceLabel.Text,RegexPrice))
                {
                    PacketPrice = Convert.ToDouble(PacketPriceLabel.Text);
                }
            }
            else
            {
                return;
            }


            if (!string.IsNullOrWhiteSpace(NumberOfChannelsLabel.Text))
            {
                if(Regex.IsMatch(NumberOfChannelsLabel.Text, RegexNumber))
                {
                    NumberOfChannel = Convert.ToInt64(NumberOfChannelsLabel.Text);
                }
            }
            else
            {
                NumberOfChannel = -1;
            }

            if (!string.IsNullOrWhiteSpace(InternetSpeedLabel.Text))
            {
                if(Regex.IsMatch(InternetSpeedLabel.Text, RegexPrice))
                {
                    InternetSpeed = Convert.ToDouble(InternetSpeedLabel.Text);
                }
            }
            else
            {
                InternetSpeed = -1;
            }


            PacketBuilder packetBuilder = new PacketBuilder()
            .SetName(PacketName)
            .SetPrice(PacketPrice)
            .SetNumberOfChannels(NumberOfChannel)
            .SetInternetSpeed(InternetSpeed);

            Packet packet = packetBuilder.Build();

            applicationLogic.AddPacket(packet);

            FillPacketPanelByPacketType(PacketType.INTERNET,null);
            FillPacketPanelByPacketType(PacketType.TV,null);
            FillPacketPanelByPacketType(PacketType.COMBINED, null);
        }

        private void NumberOfChannelsLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientInformationPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
