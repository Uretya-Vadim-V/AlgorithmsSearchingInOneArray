using AlgorithmsSearchingInOneArray;
using System;
using Xunit;

namespace AlgorithmsTests
{
    public class BinaryIterativeWorstTest
    {
        static Random random = new();
        [Fact]
        public void Test1()
        {
            int[] array = new int[1000000];
            array = Program.Worst(array);
            Array.Sort(array);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, 1);
            Assert.Equal(result, -1);
        }
        [Fact]
        public void Test2()
        {
            int[] array = new int[2000000];
            array = Program.Worst(array);
            Array.Sort(array);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, 1);
            Assert.Equal(result, -1);
        }
        [Fact]
        public void Test3()
        {
            int[] array = new int[3000000];
            array = Program.Worst(array);
            Array.Sort(array);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, 1);
            Assert.Equal(result, -1);
        }
        [Fact]
        public void Test4()
        {
            int[] array = new int[4000000];
            array = Program.Worst(array);
            Array.Sort(array);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, 1);
            Assert.Equal(result, -1);
        }
        [Fact]
        public void Test5()
        {
            int[] array = new int[5000000];
            array = Program.Worst(array);
            Array.Sort(array);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, 1);
            Assert.Equal(result, -1);
        }
    }
}