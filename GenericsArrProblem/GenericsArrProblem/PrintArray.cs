﻿using System;
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
            Console.WriteLine("\nDisplaying integer numbers");
            foreach (int element in array)
            {
                Console.Write(element+ " ");
            }
        }
        public static void ToPrint(double[] array)
        {
            Console.WriteLine("\nDisplaying double numbers");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
        public static void ToPrint(char[] array)
        {
            Console.WriteLine("\nDisplaying  numbers");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }

    }
}
