using Grpc.Core;
using Grpc.Net.Client;
using raftService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;

namespace Part1
{
    internal class RaftServer
    { 
        public  void Start(string host,int port, string[] node,int serverid)
        { 
            Task.Run(() =>
            {
                var channel= new ChannelBase(host, port, ChannelCredentials.Insecure);
                

            }).Start();        
        }
    }
}
