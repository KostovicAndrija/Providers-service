using Library.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Repositories;
using Library.Utilities;
using Library.Entities;






namespace Library
{
    public class ApplicationLogic : IApplicationLogicFacade
    {
        private readonly IClientRepository clientRepository;
        private readonly IPacketRepository packetRepository;

        public ApplicationLogic()
        {
            clientRepository = new ClientRepository();
            packetRepository = new PacketRepository();
        }

        public string GiveProviderName()
        {
            return TxtParser.ParseTxtFile("config.txt")["provider"];
        }

        public Client AddClient(Client client)
        {
            try
            {
                return clientRepository.Add(client);
            }catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public IEnumerable<Client> GetAll()
        {
            try
            {
                return clientRepository.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public IEnumerable<Packet> GetAllPacketByPacketType(PacketType type,long clientId = 0)
        {
            try
            {
                IEnumerable<Packet> packets = packetRepository.GetAll();
                return packets.Where(packet => packet.PacketType == type);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
            
        }
        public Client GetClientById(long Id)
        {
            try
            {
                return clientRepository.GetById(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public Client GetClientByName(string Name)
        {
            try
            {
                return clientRepository.GetByUsername(Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void AddPacketToClient(long packedId, long clientId)
        {
            try
            {
                clientRepository.AddPacketToClient(packedId, clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemovePacketFromClient(long packedId, long clientId)
        {
            try
            {
                clientRepository.RemovePacketFromClient(packedId, clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddPacket(Packet packet)
        {
            try
            {
                packetRepository.Add(packet);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeletePacket(long packedId)
        {
            try
            {
                packetRepository.Delete(packedId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteClient(long Id)
        {
            try
            {
                clientRepository.Delete(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public double GetPricesForIds(List<long> packetIds)
        {
            try
            {
                return packetRepository.GetPricesOfPackets(packetIds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
    }
}
