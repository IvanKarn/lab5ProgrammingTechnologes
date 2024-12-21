using ConsoleApp13.proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Adapter
{
    internal class ApiAdapter : IApiRequest
    {
        private IApi api;
        private string request = "";
        public ApiAdapter(IApi api)
        {
            this.api = api;
        }
        public void MakeRequest()
        {
            api.request(request);
        }

        public void SetRequest(string request)
        {
            this.request = request;
        }
    }
}
