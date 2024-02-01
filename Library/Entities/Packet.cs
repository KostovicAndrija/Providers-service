using Library.Memento;
using System;
using System.Runtime.CompilerServices;

namespace Library.Entities
{
    public class Packet : Entity, IPrototype<Packet>
    {
        private string name;
        private double price;
        private long numberOfChannels = -1;
        private double internetSpeed = -1;
        private PacketType packetType = PacketType.NONE;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; } 
        public long NumberOfChannels 
        { 
            get => numberOfChannels;
            set
            {
                if (value != -1 && !(value > 0))
                    throw new Exception("Invalid value for number of channels!");

                numberOfChannels = value;

                if (value == -1)
                {
                    if (PacketType == PacketType.COMBINED)
                    {
                        PacketType = PacketType.INTERNET;
                    } else if (PacketType == PacketType.TV)
                    {
                        PacketType = PacketType.NONE;
                    }
                } else
                {
                    if (PacketType == PacketType.NONE)
                    {
                        PacketType = PacketType.TV;
                    } else if (PacketType == PacketType.INTERNET)
                    {
                        PacketType = PacketType.COMBINED;
                    }
                }
            } 
        
        } 
        public double InternetSpeed 
        { 
            get => internetSpeed;
            set
            {
                if (value != -1 && !(value > 0))
                {
                    throw new Exception("Invalid value for internet speed!");
                }

                internetSpeed = value;

                if (value == -1)
                {
                    if (PacketType == PacketType.COMBINED)
                    {
                        PacketType = PacketType.TV;
                    }
                    else if (PacketType == PacketType.INTERNET)
                    {
                        PacketType = PacketType.NONE;
                    }
                }
                else
                {
                    if (PacketType == PacketType.NONE)
                    {
                        PacketType = PacketType.INTERNET;
                    }
                    else if (PacketType == PacketType.TV)
                    {
                        PacketType = PacketType.COMBINED;
                    }
                }
            }
        }
        public PacketType PacketType { get => packetType; private set => packetType = value; }


        private Packet(long id, string name, double price, long numberOfChannels, double internetSpeed)
        {
            this.Id = id;
            this.name = name;
            this.price = price;
            this.NumberOfChannels = numberOfChannels;
            this.InternetSpeed = internetSpeed;
        }

        public static Packet Create(PacketBuilder packetBuilder)
        {
            return new Packet(packetBuilder.Id, packetBuilder.Name, packetBuilder.Price,
                                packetBuilder.NumberOfChannels, packetBuilder.InternetSpeed);
        }

        //Memento pattern
        public PacketMemento MakeSnapshot()
        {
            return new PacketMemento(this.Id, this.name, this.price, this.numberOfChannels, this.internetSpeed, this.packetType);
        }

        public void PacketMemento(PacketMemento packetMemento)
        {
            this.Id = packetMemento.Id;
            this.name = packetMemento.name;
            this.price = packetMemento.price;
            this.numberOfChannels = packetMemento.numberOfChannels;
            this.internetSpeed = packetMemento.internetSpeed;
            this.packetType = packetMemento.packetType;
        }

        //Prototype pattern

        public Packet Clone()
        {
            return new Packet(this);
        }
        public Packet(Packet packet)
        {
            this.Id = packet.Id;
            this.name = packet.name;
            this.price = packet.price;
            this.numberOfChannels = packet.numberOfChannels;
            this.internetSpeed = packet.internetSpeed;
            this.packetType = packet.packetType;
        }

        public override string ToString()
        {
            return $"Packet ID: {this.Id}, Name: {this.name}, Price: {this.price}, Packet Type: {this.PacketType}" +
                    $" Number of Channels: {this.numberOfChannels}, Internet Speed: {this.internetSpeed}";
        }
    }

    public enum PacketType
    {
        NONE,
        INTERNET,
        TV,
        COMBINED
    }
}