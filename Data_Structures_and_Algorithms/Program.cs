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
            Stack stack = new Stack(10);

            for(int i = 0; i < 3; i++)
            {
                stack.Push("Squirtle");
                stack.Push("Pikachu");
                stack.Push("Charmander");
            }
            stack.Pop();
            stack.Peek();

            while (!stack.isEmpty())
            {
                var var = stack.Pop();
                Console.WriteLine(var);
            }

        }
    }
}
