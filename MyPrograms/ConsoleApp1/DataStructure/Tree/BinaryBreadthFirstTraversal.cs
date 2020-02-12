using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataStructure.Tree
{
    // Level order traversal
    class BinaryBreadthFirstTraversal
    {
        public Node rootNode;

        public void RunAll()
        {
            CreateTree();
            Travserse(rootNode);
        }

        public void CreateTree()
        {
            var arr = new int[10] { 91, 100, 21, 34, 50, 120, 110, 105, 12, 5 };
            for (int index = 0; index < arr.Length; index++)
            {
                rootNode = Insert(rootNode, arr[index]);
            }
        }

        public Node Insert(Node rootNode, int number)
        {
            if (rootNode is null)
            {
                rootNode = new Node(number);
            }
            else if (number < rootNode.Data)
            {
                rootNode.LeftNode = Insert(rootNode.LeftNode, number);
            }
            else
            {
                rootNode.RightNode = Insert(rootNode.RightNode, number);
            }
            return rootNode;
        }

        public void Travserse(Node rootNode)
        {
            if(rootNode is null)
            {
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(rootNode);

            while(queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.Write(node.Data);
                Console.Write("\n");
                if (node.LeftNode != null)
                    queue.Enqueue(node.LeftNode);
                
                if(node.RightNode != null)
                   queue.Enqueue(node.RightNode);
            }
        }
    }
}
