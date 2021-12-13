using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Stack<char> bracket1 = new Stack<char>();
            bracket1.Push('1');
            Stack<char> bracket2 = new Stack<char>();
            bracket2.Push('1');
            Stack<char> bracket3 = new Stack<char>();
            bracket3.Push('1');
            string str = "{h}((ffg))d[[dd(jj])]";
            char[] arr;

            arr = str.ToCharArray();
            foreach (char i in arr)
            {
                try
                {
                    if (i == '{')
                        bracket1.Push(')');
                    if (i == '(')
                        bracket2.Push(')');
                    if (i == '[')
                        bracket3.Push(']');
                    if (i == '}')
                        bracket1.Pop();
                    if (i == ')')
                        bracket2.Pop();
                    if (i == ']')
                        bracket3.Pop();
                }
                catch
                {
                    Console.WriteLine("Скобки расставлены не корректно");
                    break;
                }
            }
            try
            {
                if (bracket1.Peek() == bracket2.Peek() && bracket1.Peek() == bracket3.Peek() && bracket3.Peek() == bracket2.Peek())
                {
                    Console.WriteLine("Скобки расставлены корректно");
                }
                else
                {
                    Console.WriteLine("Скобки расставлены не корректно");
                }
            }
            catch
            {
                Console.WriteLine("Скобки расставлены не корректно");
            }
            Console.ReadKey();
        }
    }
}
