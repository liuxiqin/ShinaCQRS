using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.Eventing
{
    public abstract class DomainEvent:IDomainEvent
    {
        public DomainEvent()
        {

        }
    }

    public interface IDomainEvent { 
        
    }
} 
