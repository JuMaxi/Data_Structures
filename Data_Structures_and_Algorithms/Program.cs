using Data_Structures_and_Algorithms.ADT;
using System;
using System.Data;
using System.Threading;

namespace Data_Structures_and_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack(10);
            Stack stack1 = new Stack(10);
            Stack stack2 = new Stack(10);
            Stack stack3 = new Stack(10);

            stack1.Push("[Z]");
            stack1.Push("[N]");
            stack1.Push("[D]");

            stack2.Push("[M]");
            stack2.Push("[C]");

            stack3.Push("[P]");

            //remove 1 from 2 to 1
            var item = stack2.Pop();
            stack1.Push(item);

            PrintStack(stack1);
            PrintStack(stack2);
            PrintStack(stack3);

            //for(int i = 0; i < 3; i++)
            //{
            //    stack.Push("Squirtle");
            //    stack.Push("Pikachu");
            //    stack.Push("Charmander");
            //}
            //stack.Pop();
            //stack.Peek();

            //while (!stack.isEmpty())
            //{
            //    var var = stack.Pop();
            //    Console.WriteLine(var);
            //}

        }

        private static void PrintStack(Stack stack)
        {
            while (!stack.isEmpty())
            {
                var var = stack.Pop();
                Console.WriteLine(var);
            }
            Console.WriteLine("");
        }
    }
}
