using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.EventStore
{
    public class EventStore:IEventStore
    {
        public void CreateNewStream(string streamName, IEnumerable<Eventing.DomainEvent> domainEvents)
        {
            throw new NotImplementedException();
        }

        public void AppendEventsToStream(string streamName, IEnumerable<Eventing.DomainEvent> domainEvents, int expectedVersion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Eventing.DomainEvent> GetStream(string streamname, int fromVersion, int toVersion)
        {
            throw new NotImplementedException();
        }

        public void AddSnapshot<T>(string stream, T snapShot)
        {
            throw new NotImplementedException();
        }

        public T GetLatestSnapshot<T>(string streamName) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
