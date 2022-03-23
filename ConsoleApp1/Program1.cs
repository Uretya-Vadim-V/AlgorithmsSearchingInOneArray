using System;
using AlgorithmsSearchingInOneArray;

namespace ConsoleApp1
{
    public class Program1
    {
        public void Main(string[] args)
        {
            int[] array = new int[1000001];
            array = Program.Worst(array);
            array[1000000] = 1;
            for (int  i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
