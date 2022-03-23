using AlgorithmsSearchingInOneArray;
using System;
using Xunit;

namespace AlgorithmsTests
{
    public class LinearWithBarrierInDisorderedArrayWorstTest
    {
        static Random random = new();
        [Fact]
        public void Test1()
        {
            int[] array = new int[1000001];
            array = Program.Worst(array);
            array[1000000] = 1;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, 1);
            Assert.Equal(result, -1);
        }
        [Fact]
        public void Test2()
        {
            int[] array = new int[2000001];
            array = Program.Worst(array);
            array[2000000] = 1;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, 1);
            Assert.Equal(result, -1);
        }
        [Fact]
        public void Test3()
        {
            int[] array = new int[3000001];
            array = Program.Worst(array);
            array[3000000] = 1;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, 1);
            Assert.Equal(result, -1);
        }
        [Fact]
        public void Test4()
        {
            int[] array = new int[4000001];
            array = Program.Worst(array);
            array[4000000] = 1;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, 1);
            Assert.Equal(result, -1);
        }
        [Fact]
        public void Test5()
        {
            int[] array = new int[5000001];
            array = Program.Worst(array);
            array[5000000] = 1;
            // вызов тестируемого алгоритма, получение результата
            int result = Search.LinearWithBarrierInDisorderedArray(array, 1);
            Assert.Equal(result, -1);
        }
    }
}