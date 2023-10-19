using Data_Structures_and_Algorithms.ADT;
using System;
using System.Data;
using System.Threading;
using System.Collections.Generic;

namespace Data_Structures_and_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Node nodeA = new Node();
            //nodeA.Data = 865;

            //Node nodeB = new Node();
            //nodeB.Data = 344;

            //Node nodeC = new Node();
            //nodeC.Data = 888;

            //Node nodeD = new Node();
            //nodeD.Data = 222;

            //nodeA.Next = nodeB;
            //nodeB.Next = nodeC;
            //nodeC.Next = nodeD;

            
            Node firstElement = new() { Data = 100 };

            AddItem(firstElement, 200);
            AddItem(firstElement, 300);
            AddItem(firstElement, 400);
            AddItem(firstElement, 500);
            AddItem(firstElement, 600);
            AddItem(firstElement, 700);

            PrintLinkedList(firstElement); // Print all elements in the list, one by line

            int totalItems = CountLinkedList(firstElement);
            Console.WriteLine(" ");
            Console.WriteLine($"The list contains {totalItems} items.");





            //    //Stack stack = new Stack(10);
            //    Stack stack1 = new Stack(10);
            //    Stack stack2 = new Stack(10);
            //    Stack stack3 = new Stack(10);

            //    stack1.Push("[Z]");
            //    stack1.Push("[N]");
            //    stack1.Push("[D]");

            //    stack2.Push("[M]");
            //    stack2.Push("[C]");

            //    stack3.Push("[P]");

            //    //remove 1 from 2 to 1
            //    var item = stack2.Pop();
            //    stack1.Push(item);

            //    PrintStack(stack1);
            //    PrintStack(stack2);
            //    PrintStack(stack3);

            //    //for(int i = 0; i < 3; i++)
            //    //{
            //    //    stack.Push("Squirtle");
            //    //    stack.Push("Pikachu");
            //    //    stack.Push("Charmander");
            //    //}
            //    //stack.Pop();
            //    //stack.Peek();

            //    //while (!stack.isEmpty())
            //    //{
            //    //    var var = stack.Pop();
            //    //    Console.WriteLine(var);
            //    //}

            //}

            //private static void PrintStack(Stack stack)
            //{
            //    while (!stack.isEmpty())
            //    {
            //        var var = stack.Pop();
            //        Console.WriteLine(var);
            //    }
            //    Console.WriteLine("");
            //}
        }

        
        private static void AddItem(Node firstElement, int value)
        {
            Node temp = firstElement;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = new Node() { Data = value };
        }

        private static void PrintLinkedList(Node firstElement)
        {
            Node temp = firstElement;

            while(temp.Next != null)
            {
                Console.WriteLine("The data is: " + temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine("The data is: " + temp.Data);
        }

        private static int CountLinkedList(Node firstElement)
        {
            int count = 1;

            Node temp = firstElement;

            while(temp.Next != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }


    }
}
