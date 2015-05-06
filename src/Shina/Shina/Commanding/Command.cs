using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.Command
{
    public abstract class Command : ICommand
    {
        public Command(string aggregateRootId)
        {
            if (string.IsNullOrEmpty(aggregateRootId))
            {
                throw new ArgumentNullException("aggregateRootId");
            }
            AggregateRootId = AggregateRootId;
        }

        public string AggregateRootId
        {
            get;
            set;
        }
    }
}
