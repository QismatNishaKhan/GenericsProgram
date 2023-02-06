using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArrProblem
{
    public class GenericPrintArray
    {
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("\nDisplaying f numbers");
            foreach (T element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
