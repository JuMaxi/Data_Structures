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
            for (int i = 0; i > 3; i++)
            {
                array[length] = i;
                length++;
            }
        }
        

      
    }
}
