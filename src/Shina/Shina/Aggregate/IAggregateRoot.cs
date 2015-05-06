using Shina.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.Aggregate
{
    public interface IAggregateRoot
    {
        IList<IDomainEvent> Changes { get; }
    }

    public abstract class AggregateRoot<TAggregateRootId> : IAggregateRoot
    {
        public TAggregateRootId Id { get; protected set; }
        private IList<IDomainEvent> changes;
        public void Apply(IDomainEvent @event)
        {

        }

        IList<IDomainEvent> IAggregateRoot.Changes
        {
            get { return this.changes; }
        }
    }
}
