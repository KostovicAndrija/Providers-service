using Library.Entities;
using Library.Repositories.Interfaces;
using Library.Utilities.Database;
using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Repositories.Interfaces;

namespace Library.Repositories
{
    public class ClientRepository : IClientRepository, IClientObserver
    {
        public static event Action<long, long> SubscribeClient;
        public static event Action<long, long> UnsubscribeClient;
        public Client Add(Client entity)
        {
            if (entity.Username == null || entity.FirstName == null || entity.LastName == null)
            {
                throw new Exception("Tried to add new client with no username/first_name/last_name!");
            }

            if (GetByUsername(entity.Username) != null)
            {
                throw new Exception("Client with given username already exists!");
            }

            string query = "INSERT INTO clients(username, first_name, last_name) VALUES (@0, @1, @2)";
            List<object> parameters = new List<object> { entity.Username, entity.FirstName, entity.LastName };

            Database.Instance.Update(query, parameters);

            return GetByUsername(entity.Username);
        }

        public void Delete(long id)
        {
            if (GetById(id) == null)
                throw new Exception("Tried to delete client that does not exist in database!");

            string query = "DELETE FROM clients WHERE client_id = @0";
            List<object> parameters = new() { id };

            string query1 = "DELETE FROM clients_packets WHERE client_id = @0";

            Database.Instance.Update(query1, parameters);
            Database.Instance.Update(query, parameters);
        }

        public IEnumerable<Client> GetAll()
        {
            string query = "SELECT * FROM clients";
            var rows = Database.Instance.Query(query, null);

            List<Client> clients = new List<Client>();

            foreach (var row in rows)
            {
                Client client = GetById((long)row["client_id"]);

                clients.Add(client);
            }

            return clients;
        }

        public Client GetById(long id)
        {
            string query = "SELECT * FROM clients WHERE client_id = @0";
            List<object> parameters = new List<object> { id };

            var row = Database.Instance.Query(query, parameters);

            if (row.Count == 0)
                return null;

            Client client = new Client((long) row[0]["client_id"], (string) row[0]["username"], 
                                (string) row[0]["first_name"], (string) row[0]["last_name"]);

            string query1 = "SELECT * FROM clients_packets where client_id = @0";
            List<object> parameters1 = new() { client.Id };

            var rows = Database.Instance.Query(query1, parameters1);

            foreach (var packet in rows)
            {
                client.ListOfPackets.Add((long)packet["packet_id"]);
            }

            return client;
        }

        public Client GetByUsername(string username)
        {
            string query = "SELECT * FROM clients where username = @0";
            List<object> parameters = new() { username };

            var row = Database.Instance.Query(query, parameters);

            if (row.Count == 0)
                return null;

            Client client =  new Client((long)row[0]["client_id"], (string)row[0]["username"], (string)row[0]["first_name"],
                            (string) row[0]["last_name"]);

            string query1 = "SELECT * FROM clients_packets where client_id = @0";
            List<object> parameters1 = new() { client.Id };

            var rows = Database.Instance.Query(query1, parameters1);

            foreach (var packet in rows)
            {
                client.ListOfPackets.Add((long)packet["packet_id"]);
            }

            return client;
        }

        public Client Update(Client entity)
        {
            if (entity.Username == null || entity.FirstName == null || entity.LastName == null)
            {
                throw new Exception("Tried to update entity with null properties!");
            }

            Client client = GetByUsername(entity.Username);

            if (client != null && entity.Id != client.Id)
            {
                throw new Exception("Tried to update entity with already used username!");
            }

            string query = "UPDATE clients SET username = @0, first_name = @1, last_name = @2 WHERE client_id = @3";
            List<object> parameters = new List<object> { entity.Username, entity.FirstName, entity.LastName, entity.Id };

            Database.Instance.Update(query, parameters);

            return entity;
        }

        public void AddPacketToClient(long packetId, long clientId)
        {
            string query = "INSERT INTO clients_packets (packet_id,client_id) values (@0, @1)";
            List<object> parameters = new () { packetId , clientId };

            Database.Instance.Update(query, parameters);
            SubscribeClientToPacket(packetId, clientId);
        }

        public void SubscribeClientToPacket(long packetId, long clientId)
        {
            SubscribeClient?.Invoke(packetId, clientId);
        }

        public void RemovePacketFromClient(long packetId, long clientId)
        {
            string query = "DELETE FROM clients_packets WHERE packet_id = @0 and client_id = @1";
            List<object> parameters = new() { packetId, clientId };

            Database.Instance.Update(query, parameters);
            UnsubscribeClientFromPacket(packetId, clientId);
        }

        public void UnsubscribeClientFromPacket(long packetId, long clientId)
        {
            UnsubscribeClient?.Invoke(packetId, clientId);
        }
    }
}
