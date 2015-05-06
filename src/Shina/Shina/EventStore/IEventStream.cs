using Shina.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.EventStore
{
    public class DomainEventStream
    {
        public DomainEventStream(string aggregateRootId,int version,DateTime timestamp,IEnumerable<IDomainEvent> events)
        {
            AggregateRootId = aggregateRootId;
            Version = version;
            Events = events;
            Timestamp = timestamp;
        }
 
        public string AggregateRootId { get; private set; }

        public int Version { get; private set; }
        public IEnumerable<IDomainEvent> Events { get; private set; }

        public DateTime Timestamp { get; private set; }

    }
}
