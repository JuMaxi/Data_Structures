using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.ADT
{
    public class Arrays
    {
        // Arrays
        // Arrays insertions and deletions

        //Inserting at the end of an Array

        int[] array = new int[6];

        int length = 0;

        public void RunArray()
        {
            for (int i = 0; i < 3; i++)
            {
                array[length] = i + 1;
                length++;
            }
        }

        //Inserting at the start of an array 
        public void InsertInitialArray()
        {
            for(int i = 3; i <= 0; i--)
            {
                array[i + 1] = array[i];
            }

            array[0] = 8;
        }
        
        public void InsertAnyWhereArray()
        {
            //Shift each element um position to the right
            for(int i = 4; i >= 2; i--)
            {
                array[i + 1] = array[i];
            }

            array[2] = 8;
        }

      
    }
}
