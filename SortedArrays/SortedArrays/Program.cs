using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values for the first array: ");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Enter the values for the second array: ");
            string secondInput = Console.ReadLine();


            string[] firstArray = firstInput.Split(',');
            string[] secondArray = secondInput.Split(',');
            int[] finalArrayInt;

            // Before we can start sorting, we need to convert the array to an integer array to allow numbers greater than 9 to be sorted correctly
            int[] firstArrayInt = Array.ConvertAll(firstArray, int.Parse);
            int[] secondArrayInt = Array.ConvertAll(secondArray, int.Parse);

            Array.Sort(firstArrayInt);
            Array.Sort(secondArrayInt);

            finalArrayInt = new int[firstArrayInt.Length + secondArrayInt.Length];
            Array.Copy(firstArrayInt, finalArrayInt, firstArray.Length);
            Array.Copy(secondArrayInt, 0, finalArrayInt, firstArray.Length, secondArray.Length);

            Array.Sort(finalArrayInt);

            Console.WriteLine("The arrays merged together forms: ");
            for(int i = 0; i < finalArrayInt.Length; i++)
            {
                Console.Write(finalArrayInt[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
