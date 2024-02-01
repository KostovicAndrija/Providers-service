using Library.Memento;
using Library.Repositories;
using Library.Repositories.Interfaces;
using Library.Repositories;
using System;

namespace Library.Entities
{
    public class Client : Entity, IPrototype<Client>
    {
        private string username = null;
        private string firstName = null;
        private string lastName = null;
        private List<long> listOfPackets = new ();
        private ClientMemento memento = null;

        public string FirstName 
        { 
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public ClientMemento Memento
        {
            get => memento;
            private set => memento = value;
        }

        public List<long> ListOfPackets { get => listOfPackets; }

        public Client()
        {

        }
        public Client(long id, string username, string firstName, string lastName)
        {
            PacketRepository.PacketDeleted += PacketDeleted;
            ClientRepository.SubscribeClient += PacketAdded;
            ClientRepository.UnsubscribeClient += PacketDeleteFromClient;
            Id = id;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Memento pattern
        public ClientMemento MakeSnapshot()
        {
            return new ClientMemento(this.Id,this.username,this.firstName,this.lastName,this.ListOfPackets);
        }

        public void RestoreSnapshot(ClientMemento clientMemento)
        {
            this.Id = clientMemento.Id;
            this.username = clientMemento.username;
            this.firstName = clientMemento.firstName;
            this.lastName = clientMemento.lastName;
            this.listOfPackets = clientMemento.listOfPackets;
        }

        //Prototype pattern

        public Client Clone()
        {
            return new Client(this);
        }
        public Client(Client client)
        {
            this.Id = client.Id;
            this.username = client.username;
            this.firstName = client.firstName;
            this.lastName = client.lastName;
        }

        public void PacketDeleted(long id)
        {
            if(ListOfPackets.Contains(id))
            {
                Memento = MakeSnapshot();
                ListOfPackets.Remove(id);
            }
        }

        public void PacketAdded(long packetId, long clientId)
        {
            if (this.Id == clientId && !this.ListOfPackets.Contains(packetId))
            {
                Memento = MakeSnapshot();
                this.ListOfPackets.Add(packetId);
            }
        }

        public void PacketDeleteFromClient(long packetId, long clientId)
        {
            if (this.Id == clientId && this.ListOfPackets.Contains(packetId))
            {
                Memento = MakeSnapshot();
                this.ListOfPackets.Remove(packetId);
            }
        }

        public override string ToString()
        {
            return $" Username: {Username}, First Name: {FirstName}, Last Name: {LastName}";
        }
    }
}

