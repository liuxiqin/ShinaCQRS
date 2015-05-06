using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.Command
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Handler(T command);
    }
}
