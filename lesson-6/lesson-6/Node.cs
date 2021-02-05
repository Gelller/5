using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6
{
    
    
        public class Node
        {
            public int Value { get; set; }
             //статус для обхода графов
            public int Status { get; set; }
            public List<Edge> Edges { get; set; }
        }

        public class Edge
        {

            public Node Node { get; set; }
            public int Weight { get; set; }
        }
}
