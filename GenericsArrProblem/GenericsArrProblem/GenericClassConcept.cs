using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArrProblem
{
    public class GenericClassConcept<T>
    {
        public T[] array;
        public GenericClassConcept(T[] array)
        {
            this.array = array;    
        }
        public void ToPrint()
        {
            Console.WriteLine("\nDisplaying  numbers");
            foreach(T element in array)
            {
                Console.Write(element + " ");
            }

        }
    }
}
