using AlgorithmsSearchingInOneArray;
using System;
using Xunit;

namespace AlgorithmsTests
{
    public class LinearWithBarrierInDisorderedArrayAverageTest
    {
        static Random random = new();
        [Fact]
        public void Test1()
        {
            int[] array = new int[1000001];
            array = Program.Average(array);
            int element = random.Next(0, array.Length - 1);
            array[1000000] = element;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, element);
            Assert.Equal(result, element);
        }
        [Fact]
        public void Test2()
        {
            int[] array = new int[2000001];
            array = Program.Average(array);
            int element = random.Next(0, array.Length - 1);
            array[2000000] = element;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, element);
            Assert.Equal(result, element);
        }
        [Fact]
        public void Test3()
        {
            int[] array = new int[3000001];
            array = Program.Average(array);
            int element = random.Next(0, array.Length - 1);
            array[3000000] = element;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, element);
            Assert.Equal(result, element);
        }
        [Fact]
        public void Test4()
        {
            int[] array = new int[3000001];
            array = Program.Average(array);
            int element = random.Next(0, array.Length - 1);
            array[3000000] = element;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, element);
            Assert.Equal(result, element);
        }
        [Fact]
        public void Test5()
        {
            int[] array = new int[3000001];
            array = Program.Average(array);
            int element = random.Next(0, array.Length - 1);
            array[3000000] = element;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, element);
            Assert.Equal(result, element);
        }
    }
}