using Library.Entities;
using Library.Repositories.Interfaces;
using Library.Utilities.Database;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class PacketRepository : IPacketRepository
    {
        public static event Action<long> PacketDeleted;

        public Packet Add(Packet entity)
        {
            if(entity.NumberOfChannels == -1 &&  entity.InternetSpeed == -1)
            {
                throw new Exception("Packet must be internet/tv/combined");
            }

            string query = "INSERT INTO packets(name, price) VALUES (@0, @1)";
            List<object> parameters = new List<object> { entity.Name, entity.Price };


            Database.Instance.Update(query, parameters);

            long channelNumber = entity.NumberOfChannels;
            double speedNet = entity.InternetSpeed;


            entity = GetPacketByName(entity.Name);

                
            if(channelNumber != -1)
            {
                string query1 = "INSERT INTO tv_packets(packet_id,number_of_channels) VALUES (@0, @1)";
                List<object> parameters1 = new List<object> { entity.Id, channelNumber };
                Database.Instance.Update(query1, parameters1);
            }

            if(speedNet != -1)
            {
                string query1 = "INSERT INTO internet_packets(packet_id,internet_speed) VALUES (@0, @1)";
                List<object> parameters1 = new List<object> { entity.Id, speedNet };
                Database.Instance.Update(query1, parameters1);
            }
            entity.NumberOfChannels = channelNumber;
            entity.InternetSpeed = speedNet;

            return entity;
        }

        public void Delete(long id)
        {
            if (GetById(id) == null)
                throw new Exception("Tried to delete packet that does not exist in database!");

            string query = "DELETE FROM packets WHERE packet_id = @0";
            List<object> parameters = new() { id };

            string query1 = "DELETE FROM clients_packets WHERE packet_id = @0";
            List<object> parameters1 = new() { id };

            string query2 = "DELETE FROM tv_packets WHERE packet_id = @0";

            string query3 = "DELETE FROM internet_packets WHERE packet_id = @0";


            Database.Instance.Update(query2, parameters);
            Database.Instance.Update(query3, parameters);
            Database.Instance.Update(query1, parameters1);
            Database.Instance.Update(query, parameters);
            PacketDeleted?.Invoke(id);
        }

        public IEnumerable<Packet> GetAll()
        {
            string query = "SELECT p.packet_id, p.name, p.price, t.number_of_channels, i.internet_speed FROM packets p LEFT JOIN internet_packets i ON p.packet_id = i.packet_id LEFT JOIN tv_packets t ON p.packet_id = t.packet_id ORDER BY p.price";
            var rows = Database.Instance.Query(query, null);

            List<Packet> packets = new List<Packet>();
            int br = 0;
            foreach (var row in rows)
            {
                PacketBuilder packetBuilder = new PacketBuilder()
                    .SetName((string)row["name"])
                    .SetPrice((double)row["price"])
                    .SetId((long)row["packet_id"]);

                if (!row["internet_speed"].Equals(DBNull.Value))
                {
                    packetBuilder.SetInternetSpeed((double)row["internet_speed"]);
                }

                if (!row["number_of_channels"].Equals(DBNull.Value))
                {
                    packetBuilder.SetNumberOfChannels((long)row["number_of_channels"]);
                }

                Packet packet = packetBuilder.Build();
                packets.Add(packet);

                br++;
            }

            return packets;
        }


        public Packet GetById(long id)
        {
            string query = "SELECT p.packet_id,p.name,p.price,t.number_of_channels,i.internet_speed FROM packets p LEFT JOIN tv_packets t ON p.packet_id = t.packet_id  LEFT JOIN " +
                                                         "internet_packets i ON p.packet_id = i.packet_id WHERE p.packet_id = @0";
            List<object> parameters = new List<object> { id };

            var result = Database.Instance.Query(query, parameters);

            if (result.Count == 0)
            {
                return null;
            }

            PacketBuilder packetBuilder = new PacketBuilder().SetName((string)result[0]["name"])
                                               .SetPrice((double)result[0]["price"]).SetId((long)result[0]["packet_id"]);


            if (!result[0]["internet_speed"].Equals(DBNull.Value))
            {
                packetBuilder.SetInternetSpeed((double)result[0]["internet_speed"]);
            }

            if (!result[0]["number_of_channels"].Equals(DBNull.Value))
            {
                packetBuilder.SetNumberOfChannels((long)result[0]["number_of_channels"]);
            }

            return packetBuilder.Build();
        }

        public Packet GetPacketByName(string name)
        {
            string query = "SELECT p.packet_id,p.name,p.price,t.number_of_channels,i.internet_speed FROM packets p LEFT JOIN tv_packets t ON p.packet_id = t.packet_id  LEFT JOIN " +
                                                        "internet_packets i ON p.packet_id = i.packet_id WHERE p.name = @0";
            List<object> parameters = new List<object> {name};

            var result = Database.Instance.Query(query, parameters);

            if (result.Count == 0)
            {
                return null;
            }

            PacketBuilder packetBuilder = new PacketBuilder().SetName((string)result[0]["name"])
                                               .SetPrice((double)result[0]["price"]).SetId((long)result[0]["packet_id"]);

            if (!result[0]["internet_speed"].Equals(DBNull.Value))
            {
                packetBuilder.SetInternetSpeed((double)result[0]["internet_speed"]);
            }

            if (!result[0]["number_of_channels"].Equals(DBNull.Value))
            {
                packetBuilder.SetNumberOfChannels((long)result[0]["number_of_channels"]);
            }
            
            return packetBuilder.Build();
        }

        public Packet Update(Packet entity)
        {
            if (entity.Name == null)
            {
                throw new Exception("Trying to update entity with null refernece!");
            }

            Packet packet = GetById(entity.Id);
            if (packet == null)
            {
                throw new Exception("Packet with this id already exists!");
            }

            
            
            if (entity.Name == packet.Name)
            {
                throw new Exception("Trying to update name with already used name!");
            }
            

            string query = "UPDATE packets SET name = @0 WHERE packet_id = @1";
            List<object> parameters = new List<object> { entity.Name, entity.Id };


            Database.Instance.Update(query, parameters);

     
            return entity;
        }

        public double GetPricesOfPackets(List<long> packetIds)
        {
            double sum = 0;
            foreach (long packetId in packetIds)
            {
                Packet packet = GetById(packetId);
                if(packet != null)
                    sum += packet.Price;
            }
            return sum;
        }
    }
}
