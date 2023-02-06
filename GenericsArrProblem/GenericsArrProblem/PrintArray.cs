using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArrProblem
{
    public class PrintArray
    {
        public static void ToPrint(int[] array)
        {
            foreach(int element in array)
            {
                Console.Write(element+ " ");
            }
        }



    }
}
