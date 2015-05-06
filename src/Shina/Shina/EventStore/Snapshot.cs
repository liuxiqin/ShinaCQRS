using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.EventStore
{
    /// <summary>
    /// 快照
    /// </summary>
    public class Snapshot
    {
        public Snapshot(string aggregateRootId, int version, byte[] payLoad, DateTime timestamp)
        {
            AggregateRootId = aggregateRootId;
            Version = version;
            PayLoad = payLoad;
            Timestamp = timestamp;
        }

        public string AggregateRootId { get; private  set; }

        public int Version { get; private set; }

        public byte[] PayLoad { get; private set; }


        public DateTime Timestamp { get; private set; }
    }
}
