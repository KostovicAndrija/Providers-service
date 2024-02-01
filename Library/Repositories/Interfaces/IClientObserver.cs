using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories.Interfaces
{
    public interface IClientObserver
    {
        void SubscribeClientToPacket(long packetId, long clientId);
        void UnsubscribeClientFromPacket(long packetId, long clientId);
    }
}
