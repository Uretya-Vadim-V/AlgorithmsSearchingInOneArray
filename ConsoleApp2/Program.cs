using System;
using AlgorithmsSearchingInOneArray;

namespace ConsoleApp1
{
    public class Program1
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int[] array = new int[3000001];
            array = Program.Worst(array);
            array[3000000] = 1;
            for (int i = 0; i < array.Length; i++)
            {
                //Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Search.LinearWithBarrierInDisorderedArray(array, 1));
            Console.WriteLine();
            Console.WriteLine();
            int[] arraya = new int[3000001];
            arraya = Program.Average(arraya);
            arraya[3000000] = 1;
            for (int i = 0; i < arraya.Length; i++)
            {
                //Console.Write(arraya[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Search.LinearWithBarrierInDisorderedArray(arraya, rand.Next(0, arraya.Length - 1)));
            Console.ReadLine();
        }
    }
}
