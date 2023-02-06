namespace GenericsArrProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] intArray = { 10, 20, 30, };
            double[] doubleArray = { 12.34, 45.12, 89.1, 77.7 };
            char[] charArray = {'c','d','g','r'};

            Console.WriteLine("Please choose a program from below option ");
            Console.WriteLine(" 1:PrintArray\n2:PrintArray using Generic Method");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(intArray);
                    PrintArray.ToPrint(doubleArray);
                    PrintArray.ToPrint(charArray);
                    Console.WriteLine();
                    break;

               case 2:
                    GenericPrintArray.ToPrint<int>(intArray);
                    GenericPrintArray.ToPrint<double>(doubleArray);
                    GenericPrintArray.ToPrint<char>(charArray);
                    break;
            }
         

        }
    }
}