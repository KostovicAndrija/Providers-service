using Library.Entities;
using Library.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        public Client GetByUsername(string username);
        public void AddPacketToClient(long packetId, long clientId);
        public void RemovePacketFromClient(long packetId, long clientId);

    }
}
