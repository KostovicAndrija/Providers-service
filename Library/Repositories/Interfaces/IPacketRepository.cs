using Library.Entities;
using Library.Repositories.Interfaces;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories.Interfaces
{
    public interface IPacketRepository : IRepository<Packet>
    {

        public Packet GetPacketByName(string name);

        public double GetPricesOfPackets(List<long> packetIds);
    }
}
