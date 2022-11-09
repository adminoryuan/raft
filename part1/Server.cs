using Grpc.Net.Client;
using raftService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Server
    { 
        public  void Start(string host)
        {
          
             Task.Run(() =>
            {
                Server server = new Server();


                server.Start(host);


            }).Start();
           

        }
    }
}
