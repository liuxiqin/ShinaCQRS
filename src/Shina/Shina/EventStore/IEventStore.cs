using Shina.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.EventStore
{
    public interface IEventStore
    {
        void CreateNewStream(string streamName, IEnumerable<DomainEvent> domainEvents);
        void AppendEventsToStream(string streamName, IEnumerable<DomainEvent> domainEvents, int expectedVersion);
        IEnumerable<DomainEvent> GetStream(string streamname, int fromVersion, int toVersion);
        void AddSnapshot<T>(string stream, T snapShot);
        T GetLatestSnapshot<T>(string streamName) where T : class;
    }
}
