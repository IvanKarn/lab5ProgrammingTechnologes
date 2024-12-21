using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Bridge
{
    internal class Monitor : IDevice
    {
        public void Print(string content)
        {
            Console.WriteLine("Display: " + content);
        }
    }
}
