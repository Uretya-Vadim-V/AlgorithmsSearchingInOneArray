using AlgorithmsSearchingInOneArray;
using System;
using Xunit;

namespace AlgorithmsTests
{
    public class JumpsInOrderedArrayWorstTest
    {
        static Random random = new();
        [Fact]
        public void Test1()
        {
            int[] array = new int[1000000];
            // вызов тестируемого алгоритма, получение результата
            Search.JumpsInOrderedArray(Program.Worst(array), random.Next(0, array.Length));
        }
        [Fact]
        public void Test2()
        {
            int[] array = new int[2000000];
            // вызов тестируемого алгоритма, получение результата
            Search.JumpsInOrderedArray(Program.Worst(array), random.Next(0, array.Length));
        }
        [Fact]
        public void Test3()
        {
            int[] array = new int[3000000];
            // вызов тестируемого алгоритма, получение результата
            Search.JumpsInOrderedArray(Program.Worst(array), random.Next(0, array.Length));
        }
        [Fact]
        public void Test4()
        {
            int[] array = new int[4000000];
            // вызов тестируемого алгоритма, получение результата
            Search.JumpsInOrderedArray(Program.Worst(array), random.Next(0, array.Length));
        }
        [Fact]
        public void Test5()
        {
            int[] array = new int[5000000];
            // вызов тестируемого алгоритма, получение результата
            Search.JumpsInOrderedArray(Program.Worst(array), random.Next(0, array.Length));
        }
    }
}