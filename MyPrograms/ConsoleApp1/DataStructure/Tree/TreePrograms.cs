using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataStructure.Tree
{
    class TreePrograms
    {
        public Node rootNode;
        public void RunAll()
        {
            FillTree();
            var height = FindTreeHeight(rootNode.RightNode.LeftNode);
            var depth = FindDepth(rootNode, rootNode.RightNode.LeftNode);
            Console.WriteLine("Binary Tree height is {0}", height);
            Console.WriteLine("Depth of 92 Node is {0}", depth);
        }

        public void FillTree()
        {
            rootNode = new Node(91)
            {
                LeftNode = new Node(12) {
                     LeftNode = new Node(111) {
                         RightNode = new Node(121)
                     },
                     RightNode = new Node(33)
                     {
                         LeftNode = new Node(56)
                     }
                },
                RightNode = new Node(11)
                {
                    LeftNode = new Node(92)
                    {
                        RightNode = new Node(1112),
                        LeftNode = new Node(34)
                        {
                            RightNode = new Node(45),
                            LeftNode = new Node(23)
                        }
                    }
                }
            };

        }

        public int FindTreeHeight(Node rootNode)
        {

            if (rootNode == null)
            {
                return -1;
            }
                     
            int leftTreeHeight = FindTreeHeight(rootNode.LeftNode);
            int rightTreeHeight = FindTreeHeight(rootNode.RightNode);

            return Math.Max(leftTreeHeight, rightTreeHeight) + 1;
        }

        public int FindDepth(Node rootNode, Node depthNode)
        {

            if (rootNode == null || rootNode == depthNode)
            {
                return 0;
            }

            int leftTreeHeight = FindDepth(rootNode.LeftNode, depthNode);
            int rightTreeHeight = FindDepth(rootNode.RightNode, depthNode);

            return 1;
        }
    }
}
