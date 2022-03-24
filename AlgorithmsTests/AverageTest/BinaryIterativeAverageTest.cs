using AlgorithmsSearchingInOneArray;
using System;
using Xunit;

namespace AlgorithmsTests
{
    public class BinaryIterativeAverageTest
    {
        static Random random = new();
        [Fact]
        public void Test1()
        {
            int[] array = new int[1000000];
            array = Program.Average(array);
            Array.Sort(array);
            int element = random.Next(0, array.Length);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, element);
            Assert.Equal(result, element);
        }
        [Fact]
        public void Test2()
        {
            int[] array = new int[2000000];
            array = Program.Average(array);
            Array.Sort(array);
            int element = random.Next(0, array.Length);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, element);
            Assert.Equal(result, element);
        }
        [Fact]
        public void Test3()
        {
            int[] array = new int[3000000];
            array = Program.Average(array);
            Array.Sort(array);
            int element = random.Next(0, array.Length);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, element);
            Assert.Equal(result, element);
        }
        [Fact]
        public void Test4()
        {
            int[] array = new int[4000000];
            array = Program.Average(array);
            Array.Sort(array);
            int element = random.Next(0, array.Length);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, element);
            Assert.Equal(result, element);
        }
        [Fact]
        public void Test5()
        {
            int[] array = new int[5000000];
            array = Program.Average(array);
            Array.Sort(array);
            int element = random.Next(0, array.Length);
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, element);
            Assert.Equal(result, element);
        }
        [Fact]
        public void TestOnly1()
        {
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, 1);
            Assert.Equal(result, 0);
        }
        [Fact]
        public void TestStartElement()
        {
            int[] array = { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, 0);
            Assert.Equal(result, 0);
        }
        [Fact]
        public void TestEndElement()
        {
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 };
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, 2);
            Assert.Equal(result, 16);
        }
        [Fact]
        public void TestMidElement()
        {
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3 };
            // вызов тестируемого алгоритма, получение результата
            int result = Search.BinaryIterative(array, 2);
            Assert.Equal(result, 8);
        }
    }
}