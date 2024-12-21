using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Bridge
{
    internal abstract class Output
    {
        protected IDevice device;
        public Output(IDevice device)
        {
            this.device = device;
        }
        public abstract void Render(string data);
    }
}
