using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Bridge
{
    internal class ImageOutput : Output
    {
        public ImageOutput(IDevice device) : base(device)
        {
        }

        public override void Render(string data)
        {
            device.Print("Image: " + data);
        }
    }
}
