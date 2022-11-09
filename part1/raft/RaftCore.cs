using Part1.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Part1.raft
{
    internal class RaftCore : IRaftCore
    {
        private RaftEntity raftEntity;

        public void DeteHeart()
        {

            Task.Run(() =>
            {

                

            }).Start();
        }

        public bool Election()
        {
            throw new NotImplementedException();
        }

        public bool ProCandidate()
        {
            throw new NotImplementedException();
        }
    }
}
