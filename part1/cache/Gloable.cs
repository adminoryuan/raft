using Part1.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Part1.cache
{
     
    internal static class Gloable
    {   

        

        /// <summary>
        /// 保持集群所有节点信息
        /// </summary>
        public readonly  static List<String> clustConfig=
                                                new List<string>();


        public static RaftEntity raftEntity;
    }
}
