using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.ADT
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void InsertFirst(int data)
        {
            //Create the node
            Node newNode = new Node();

            //Put the data in the node
            newNode.Data = data;

            //Put the old node in next
            newNode.Next = First;

            //Make de first the new node
            First = newNode;
        }

        //public Node DeleteFirst()
        //{
        //    //Assign the temporary variable
        //    Node temp = First;
        //}
    }
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }




    }
}
