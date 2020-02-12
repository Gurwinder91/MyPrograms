using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataStructure.Tree
{
    class Node
    {
        public Node(int data)
        {
            Data = data;
            LeftNode = RightNode = null;
        }
        public Node LeftNode { get; set; }
        public int Data { get; set; }
        public Node RightNode { get; set; }
    }
}
