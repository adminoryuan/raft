using Grpc.Core;
using raftService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class raftRpc: raftService.raftService.raftServiceBase
    {
        public override Task<RequestVoRes> RequestVo(RequestVoArgs request, ServerCallContext context)
        {
            return base.RequestVo(request, context);
        } 

    }
}
