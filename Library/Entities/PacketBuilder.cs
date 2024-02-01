using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class PacketBuilder
    {
        private long id;
        private string name;
        private double price;
        private long numberOfChannels = -1;
        private double internetSpeed = -1;

        public long Id { get => id; }
        public string Name { get => name; }
        public double Price { get => price; }
        public long NumberOfChannels { get => numberOfChannels; }
        public double InternetSpeed { get => internetSpeed; }

        public PacketBuilder SetId(long id)
        {
            this.id = id;
            return this;
        }

        public PacketBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public PacketBuilder SetPrice(double price)
        {
            this.price = price;
            return this;
        }

        public PacketBuilder SetNumberOfChannels(long numberOfChannels)
        {
            this.numberOfChannels = numberOfChannels;
            return this;
        }

        public PacketBuilder SetInternetSpeed(double internetSpeed)
        {
            this.internetSpeed = internetSpeed;
            return this;
        }

        public Packet Build()
        {
            return Packet.Create(this);
        }
    }
}
