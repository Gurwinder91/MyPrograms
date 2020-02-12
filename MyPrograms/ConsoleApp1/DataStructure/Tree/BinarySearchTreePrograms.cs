using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataStructure.Tree
{
    class BinarySearchTreePrograms
    {
        public Node rootNode;
        public void RunAll()
        {
            //var arr = new int[10] { 91, 100, 21, 34, 50, 120, 110, 105, 12, 5 };
            //for (int index = 0; index < arr.Length; index++)
            //{
            //    rootNode = Insert(rootNode, arr[index]);
            //}

            FillTree();
            var height = FindTreeHeight(rootNode);
            var minNumber = FindMinRecursive(rootNode);
            var maxNumber = FindMaxRecursive(rootNode);
            Console.WriteLine("Binary Tree height is {0}", height);
            Console.WriteLine("Recursive Minimum Number is {0}", minNumber);
            Console.WriteLine("Recursive Maximum Number is {0}", maxNumber);
            Console.WriteLine("Binary Search Tree is {0}", IsBinarySearchTree(rootNode));
            //Console.WriteLine("Number is Found {0}", FindNumber(rootNode, Convert.ToInt32(Console.ReadLine()))); 
        }

        public void FillTree()
        {
            rootNode = new Node(91)
            {
                LeftNode = new Node(25)
                {
                    LeftNode = new Node(10)
                    {
                        RightNode = new Node(15)
                    },
                    RightNode = new Node(33)
                    {
                        LeftNode = new Node(30)
                    }
                },
                RightNode = new Node(200)
                {
                    LeftNode = new Node(100)
                    {
                        RightNode = new Node(150),
                        LeftNode = new Node(95)
                        {
                            RightNode = new Node(98),
                            LeftNode = new Node(92)
                        }
                    }
                }
            };

        }

        public Node Insert(Node rootNode, int number)
        {
            if(rootNode is null)
            {
                rootNode = new Node(number);
            }else if(number < rootNode.Data)
            {
                rootNode.LeftNode = Insert(rootNode.LeftNode, number);
            }
            else
            {
                rootNode.RightNode = Insert(rootNode.RightNode, number);
            }
            return rootNode;
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

        public int FindMin(Node rootNode)
        {
            while(rootNode.LeftNode != null)
            {
                rootNode = rootNode.LeftNode;
            }
            return rootNode.Data;
        }

        public int FindMinRecursive(Node rootNode)
        {
            if (rootNode.LeftNode == null)
            {
                return rootNode.Data;
            }
            return FindMinRecursive(rootNode.LeftNode);
        }

        public int FindMax(Node rootNode)
        {
            while (rootNode.RightNode != null)
            {
                rootNode = rootNode.RightNode;
            }
            return rootNode.Data;
        }

        public int FindMaxRecursive(Node rootNode)
        {
            if (rootNode.RightNode == null)
            {
                return rootNode.Data;
            }
            return FindMaxRecursive(rootNode.RightNode);
        }

        public bool FindNumber(Node rootNode, int number)
        {
            if(rootNode is null)
            {
                return false;
            }else if(rootNode.Data == number)
            {
                return true;
            }else if(number < rootNode.Data)
            {
                return FindNumber(rootNode.LeftNode, number);
            }else
            {
                return FindNumber(rootNode.RightNode, number);
            }           
        }

        public void Delete(Node rootNode, int number)
        {
            if(rootNode.Data == number)
            {

            }
            else if(number < rootNode.Data)
            {
                Delete(rootNode.LeftNode, number);
            }
            else
            {
                Delete(rootNode.RightNode, number);
            }
        }

        public bool IsBinarySearchTree(Node rootNode)
        {
            if(rootNode is null)
            {
                return true;
            }

            return IsLesserValue(rootNode.LeftNode, rootNode.Data) 
                && IsGreatorValue(rootNode.RightNode, rootNode.Data)
                && IsBinarySearchTree(rootNode.LeftNode)
                && IsBinarySearchTree(rootNode.RightNode);
        }

        private bool IsLesserValue(Node rootNode, int number)
        {
            if(rootNode is null)
            {
                return true;
            }
            return rootNode.Data < number
                && IsLesserValue(rootNode.LeftNode, number) 
                && IsLesserValue(rootNode.RightNode, number);
        }

        private bool IsGreatorValue(Node rootNode, int number)
        {
            if (rootNode is null)
            {
                return true;
            }

            return number < rootNode.Data
                && IsGreatorValue(rootNode.RightNode, number) && 
                IsGreatorValue(rootNode.LeftNode, number);
        }
    }
}
