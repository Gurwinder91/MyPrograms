using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //push
    //pop
    //peek
    //empty
    class MyStack
    {
        private readonly int _maxSize = 10;
        private readonly int[] _stackArray;
        private int _top = -1;
        public MyStack()
        {
            _stackArray = new int[_maxSize];
        }

        public void Push(int element)
        {
            if(_top == _maxSize)
            {
                return;
            }
            
            _stackArray[++_top] = element;
        }

        public int Pop()
        {
            if (IsEmpty())
                return -1;

            var el = _stackArray[_top];
            _top--;
            return el;
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public int Peek()
        {
            return _stackArray[_top];
        }
    }
}
