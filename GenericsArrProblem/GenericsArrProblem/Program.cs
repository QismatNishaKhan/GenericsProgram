namespace GenericsArrProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30, };
            double[] doubleArray = { 12.34, 45.12, 89.1, 77.7 };
            char[] charArray = {'c','d','g','r'};
            PrintArray.ToPrint(intArray);
            PrintArray.ToPrint(doubleArray);
            PrintArray.ToPrint(charArray);
            Console.WriteLine();

        }
    }
}