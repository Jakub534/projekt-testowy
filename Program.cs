using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoIdditiesHere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            NoOdds(array);
            foreach(int x in array)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }

        //Write a function will return an array of non-odd values
        public static int[] NoOdds(int[] values)
        {
           //the simplest way 1) Create a new array
            int[] newOne = new int[values.Length];
            for(int i = 0;i<values.Length;i++)
            {
                if(!(values[i] % 2==0 ))
                {
                    newOne[i] = values[i];
                }

            }
            return newOne;
        }
    }
}
