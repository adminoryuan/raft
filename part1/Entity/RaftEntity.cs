using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Part1.Entity
{
    internal class RaftEntity
    {
        int currentid;

        int currentTerm;

        int VotedFor;

        LogEntity[] log;

        State state;

        int commitIndex;

        int lastApplied { get; set; }

        int Vote;

        int leaderId;

        int term;

         private ReaderWriterLock rwlock = new ReaderWriterLock();

        /// <summary>
        /// 选票加1
        /// </summary>
        /// <returns></returns>
        public bool AddVote()
        {

            
            try { 
                rwlock.AcquireWriterLock(1000);

            }catch(Exception e)
            {
                return false;
            }

            Vote += 1;

            rwlock.ReleaseWriterLock();

            return true;
        }

        /// <summary>
        // 设置投票对象
        /// </summary>
        /// <param name="id"></param>
        public void SetVoteFor(int id)
        {
            rwlock.AcquireWriterLock(1000);

            VotedFor = id;

            rwlock.ReleaseWriterLock();
        }


        public void SetTerm(int term)
        {
            rwlock.AcquireWriterLock(1000);


            this.term = term;

            rwlock.ReleaseWriterLock();
        }


        public void SetLeaderId(int _leaderId)
        {
            rwlock.AcquireWriterLock(1000);
            this.leaderId = _leaderId;

            rwlock.ReleaseWriterLock();


        }
    }
}
