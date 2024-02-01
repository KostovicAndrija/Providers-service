using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Memento
{
    public class CareTaker
    {
        private List<ClientMemento> clientMementoList = new List<ClientMemento>();
        private List<PacketMemento> packetMementoList = new List<PacketMemento>();
        public void SaveClientMemento(ClientMemento memento)
        {
            clientMementoList.Add(memento);
        }

        public void SavePacketMemento(PacketMemento memento)
        {
            packetMementoList.Add(memento);
        }

        public ClientMemento GetClientMemento(int client_id)
        {
            return clientMementoList.FirstOrDefault(memento => memento.Id == client_id);
        }

        public PacketMemento GetPacketMemento(int packet_id)
        {
            return packetMementoList.FirstOrDefault(memento => memento.Id == packet_id);
        }

    }
}
