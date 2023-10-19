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

        //Arrays
        //Deletions

        int[] intArray = new int[9];

        int l = 0;

        public void DeleteFromEndArray()
        {
            for(int i = 0; i < 6; i++)
            {
                intArray[l] = i;
                l++;
            }

            l--;

            for(int i = 0; i < l; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

       
        public void DeleteFromStartArray()
        {
            for(int i = 1; i < 6; i++)
            {
                intArray[i - 1] = array[i];
            }

            l--;
        }

        public void DeleteFromAnywhereArray()
        {
            //o valor do i aqui, e a posicao que voce quer excluir.
            for(int i = 2; i < l; i++)
            {
                intArray[i - 1] = intArray[i];
            }

            l--;
        }

        //Linear search array

        int[] arraySearch = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};

        //key means what value we are searching for
        bool LinearSearch(int[] arraySearch, int key)
        {
            for(int i = 0; i < arraySearch.Length; i++)
            {
                if (arraySearch[i] == key) return true;
            }
            return false;
        }
      
        public void write()
        {
            Console.WriteLine(LinearSearch(arraySearch, 0));
        }
    }
}
