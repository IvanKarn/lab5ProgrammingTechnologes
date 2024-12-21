using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.proxy
{
    internal class Api : IApi
    {
        public void request(string req)
        {
            Console.WriteLine("Request to API: {0}", req);
        }
    }
}
