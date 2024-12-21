using ConsoleApp13.Adapter;
using ConsoleApp13.Bridge;
using ConsoleApp13.proxy;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IApiRequest apiRequest1 = new ApiAdapter(new ProxyApi(true));
            apiRequest1.SetRequest("test1");
            apiRequest1.MakeRequest();
            IApiRequest apiRequest2 = new ApiAdapter(new ProxyApi(false));
            apiRequest2.SetRequest("test2");
            apiRequest2.MakeRequest();

            Console.WriteLine();

            Output textOnMonitor = new TextOutput(new Bridge.Monitor());
            Output textOnPrinter = new TextOutput(new Bridge.Printer());
            Output imageOnMonitor = new ImageOutput(new Bridge.Monitor());
            Output imageOnPrinter = new ImageOutput(new Bridge.Printer());
            textOnMonitor.Render("test");
            textOnPrinter.Render("test");
            imageOnMonitor.Render("test");
            imageOnPrinter.Render("test");
        }
    }
}
