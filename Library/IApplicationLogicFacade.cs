using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IApplicationLogicFacade
    {
        string GiveProviderName();
        Client AddClient(Client client);
        void DeleteClient(long Id);
        public IEnumerable<Client> GetAll();
        public IEnumerable<Packet> GetAllPacketByPacketType(PacketType type, long clientId = 0);
        public Client GetClientById(long Id);
        public Client GetClientByName(string Name);
        public void AddPacketToClient(long packedId, long clientId);
        public void RemovePacketFromClient(long packedId, long clientId);
        public void AddPacket(Packet packet);
        public void DeletePacket(long packedId);
        public double GetPricesForIds(List<long> packetIds);
    }
}
