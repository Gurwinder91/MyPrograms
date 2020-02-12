using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StringPrograms
    {
        public void RunAllPrograms()
        {
            ReverseString("Hello Gurwinder");
            ReverseStringUsingStack("Welcome to Csharp corner");

            chkPalindrome("1221");

            ReverseWordOrder("Gurwinder is very beautiful and smart guy");


            ReverseWordOrderUsingArr("Gurwinder is very beautiful and smart guy");


            ReverseWords("Welcome to Csharp corner");



            ReverseWords2ndWay("Welcome to Csharp corner");

            CountOccuranceOfEachWord("Hello world");
        }

        internal void ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(str[12]);
            Console.WriteLine(reversedstring);
        }

        private void ReverseStringUsingStack(string str)
        {
            Stack<char> stack = new Stack<char>(str.ToCharArray());
            string reversedString = string.Join("", stack);

            Console.Write("Reverse string is {0}", reversedString);
            Console.Write("\n");
        }

        private static void chkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        }

        private void ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }

        private void ReverseWordOrderUsingArr(string str)
        {
            string[] strArr = str.Split(" ");

            int start = 0;
            int end = strArr.Length - 1;

            while (start < end)
            {
                string temp = strArr[start];
                strArr[start] = strArr[end];
                strArr[end] = temp;

                start++;
                end--;
            }
            Console.WriteLine(string.Join(" ", strArr));
        }

        private void ReverseWords(string str)
        {
            int i = 0;
            string[] strArr = str.Split(" ");

            while (i < strArr.Length)
            {
                string element = strArr[i];
                char[] charArr = element.ToCharArray();

                for (int index = 0, j = charArr.Length - 1; index < j; index++, j--)
                {
                    charArr[j] = element[index];
                    charArr[index] = element[j];
                }

                strArr[i] = new String(charArr);

                i++;
            }

            Console.WriteLine(string.Join(" ", strArr));
        }



        private void ReverseWords2ndWay(string str)
        {
            StringBuilder output = new StringBuilder();
            List<char> charlist = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                        charlist.Add(str[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        output.Append(charlist[j]);

                    output.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(str[i]);
            }
            Console.WriteLine(output.ToString());
        }

        private void CountOccuranceOfEachWord(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        public void FindAllSubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }

        public void RotateLeft(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        public void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
               // var ss = num % 5;
                sum += num % 10;
                //var ff = num / 5;
                num /= 10;
            }
            Console.WriteLine(sum);
        }

        public void PrintStars(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int k = 1; k <= number - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }

    }
}
