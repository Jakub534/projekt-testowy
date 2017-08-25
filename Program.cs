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
            array = NoOdds(array);
            foreach(int x in array)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }

        //Write a function will return an array of non-odd values
        public static int[] NoOdds(int[] values)
        {
            List<int> valuesList = new List<int>(values);
            for (int i = valuesList.Count - 1; i >= 0;i-- )
            {
                if(valuesList[i]% 2 == 1)
                {
                    valuesList.RemoveAt(i);
                }
            }
            values = valuesList.ToArray();
            return values;
        }
    }
}
