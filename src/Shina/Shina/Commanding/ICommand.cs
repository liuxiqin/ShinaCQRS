using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.Command
{
    public interface ICommand
    {
        string AggregateRootId { get;  set; }

    }
}
