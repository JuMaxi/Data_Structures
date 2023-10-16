using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.ADT
{
    public class Stack
    {
        public int MaxSize { get; set; } // Array stacks you need a max size to init array
        //This holds our array.
        public string[] StackArray { get; set; }
        //This keeps track of the top.
        public int Top { get; set; }

        public Stack(int size) 
        { 

            

            //This holds constructor value
            this.MaxSize = size;
            //Creates array e size.
            this.StackArray= new string[MaxSize];
            //We give the top -1 because array is zero index, if we don't it will skip first element.
            this.Top = -1;

        }

        public void Push(string item)
        {
            Top++;
            StackArray[Top] = item;
        }

        public string Pop()
        {
            //Think placeholder
            int old_top = Top;
            //Decrement for the new top
            Top--;
            return StackArray[old_top];
        }

        public string Peek()
        {
            return StackArray[Top];
        }

        public bool isEmpty()
        {
            return Top == -1;
        }
        public bool isFull()
        {
            return (MaxSize - 1 == Top);
        }

        
    }
}
