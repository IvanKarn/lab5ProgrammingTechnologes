using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Adapter
{
    internal interface IApiRequest
    {
        public void SetRequest(string request);
        public void MakeRequest();
    }
}
