using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ServiceModel.WebSockets;

namespace WebSocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebSocketsHost<ReverseService>();
            host.AddWebSocketsEndpoint("ws://localhost:4503/reverse");
            host.Open();

            Console.ReadLine();
        }
    }
}
