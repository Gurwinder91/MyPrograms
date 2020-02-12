using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataStructure.Tree
{
    class DepthFirstTraversal
    {
        public Node rootNode;
        public void RunAll()
        {
            CreateTree();
            // <root><left><right>
            PreOrderTravserse(rootNode);

            Console.WriteLine("\n");
            Console.WriteLine(" ______________________");
            // <left><root><right>
            InOrderTravserse(rootNode);

            Console.WriteLine("\n");
            Console.WriteLine(" ______________________");
            // <left><right><root>
            PostOrderTravserse(rootNode);
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

        public void PreOrderTravserse(Node rootNode)
        {
            if (rootNode is null)
            {
                return;
            }

            Console.Write(rootNode.Data);
            Console.Write(" ");

            PreOrderTravserse(rootNode.LeftNode);
            PreOrderTravserse(rootNode.RightNode);
        }

        public void InOrderTravserse(Node rootNode)
        {
            if (rootNode is null)
            {
                return;
            }

            InOrderTravserse(rootNode.LeftNode);

            Console.Write(rootNode.Data);
            Console.Write(" ");

            InOrderTravserse(rootNode.RightNode);
        }

        public void PostOrderTravserse(Node rootNode)
        {
            if (rootNode is null)
            {
                return;
            }

            PostOrderTravserse(rootNode.LeftNode);
            PostOrderTravserse(rootNode.RightNode);

            Console.Write(rootNode.Data);
            Console.Write(" ");
        }
    }
}
