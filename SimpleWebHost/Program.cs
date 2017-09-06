using System;

namespace SimpleWebHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var webServer = new SimpleHttpServer("c:\\simpleWeb", 9050);
            //webServer.
            Console.WriteLine("Hosting c:\\simpleWeb on port 9050" );
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
