using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.EventStore
{
    public  class InMemeryEventStore:IEventStore
    {
        public void CreateNewStream(string streamName, IEnumerable<Eventing.DomainEvent> domainEvents)
        {
            throw new System.NotImplementedException();
        }

        public void AppendEventsToStream(string streamName, IEnumerable<Eventing.DomainEvent> domainEvents, int expectedVersion)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Eventing.DomainEvent> GetStream(string streamname, int fromVersion, int toVersion)
        {
            throw new System.NotImplementedException();
        }

        public void AddSnapshot<T>(string stream, T snapShot)
        {
            throw new System.NotImplementedException();
        }

        public T GetLatestSnapshot<T>(string streamName) where T : class
        {
            throw new System.NotImplementedException();
        }
    }
}
