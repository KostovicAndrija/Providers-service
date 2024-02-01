using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Memento
{
    public class PacketMemento
    {
        public long Id;
        public string name;
        public double price;
        public long numberOfChannels;
        public double internetSpeed;
        public PacketType packetType;

        public PacketMemento(long id, string name, double price, long numberOfChannels, double internetSpeed,PacketType packetType)
        {
            this.Id = id;
            this.name = name;
            this.price = price;
            this.numberOfChannels = numberOfChannels;
            this.internetSpeed = internetSpeed;
            this.packetType = packetType;
        }
    }
}
