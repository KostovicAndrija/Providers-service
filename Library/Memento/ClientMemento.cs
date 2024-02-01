using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Memento
{
    public class ClientMemento
    {
        public long Id;
        public string username = null;
        public string firstName = null;
        public string lastName = null;
        public List<long> listOfPackets = new();

        public ClientMemento(long id, string username, string firstName, string lastName, List<long> list)
        {
            Id = id;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.listOfPackets = new List<long>(list);
        }
    }
}
