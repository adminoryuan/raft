using System;
using System.Collections.Generic;
using System.Text;

namespace Part1.Entity
{
    internal class NodeEntity
    {
        int currentid { get; set; }

        int currentTerm { get; set; }

        int VotedFor { get; set; }
        
        LogEntity[] log { get; set; }

        State state { get; set; }
        
        int commitIndex { get; set; }

        int lastApplied { get; set; }


        int leaderId { get; set; }

            


    }
}
