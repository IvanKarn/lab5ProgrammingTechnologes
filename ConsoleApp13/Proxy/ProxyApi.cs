using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.proxy
{
    internal class ProxyApi : IApi
    {
        bool access = false;
        Api api = new Api();
        public ProxyApi(bool hasAccess) { 
            access = hasAccess;
        }
        public void request(string req)
        {
            if (access)
            {
                api.request(req);
            }
            else
            {
                Console.WriteLine("not registered user try to access to api");
            }
        }

    }
}
