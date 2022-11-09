using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{

    internal interface IRaftCore
    {
        bool ProCandidate();

        bool Election();


        void  DeteHeart();

    }
}
