using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Bridge
{
    internal class TextOutput : Output
    {
        public TextOutput(IDevice device) : base(device)
        {
        }

        public override void Render(string data)
        {
            device.Print("Text: " + data);
        }
    }
}
