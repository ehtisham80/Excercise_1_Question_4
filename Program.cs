using System;

namespace Excercise_1_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
              

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


             
             for(i=0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i] +"  is Even");
                }
                 
            }
        }
    }
}
