using System;

namespace AlgorithmsSearchingInOneArray
{
    public static class Search
    {
        static int index, badElement = -1;
        // линейный
        public static int LinearInUnorderedArray(int[] array, int element)
        {
            index = 0;
            int lenght = array.Length;
            while (index < lenght && array[index] != element)
            {
                index++;
            }
            if (index >= lenght)
                return badElement;
            return index;
        }
        // линейный с барьером
        public static int LinearWithBarrierInDisorderedArray(int[] array, int element)
        {
            index = 0;
            while (array[index] != element)
            {
                index++;
            }
            if (index >= array.Length - 1)
                return badElement;
            return index;
        }
        // быстрый линейный
        public static int FastLinearInOrderedArray(int[] array, int element)
        {
            index = 0;
            int lenght = array.Length;
            while (index < lenght && array[index] < element)
            {
                index++;
            }
            if (index >= lenght || array[index] != element)
                return badElement;
            return index;
        }
        // бинарный итерационный
        public static int BinaryIterative(int[] array, int element)
        {
            int mid, left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                mid = left + (right - left) / 2;      
                if (array[mid] >= element)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            if (array[left] == element)
                return left;
            return badElement;
        }
        // бинарный рекурсивный
        public static int BinaryRecursive(int[] array, int element)
        {
            if (array.Length == 0)
                return badElement;
            return BinaryRecursive_Func(array, element, 0, array.Length - 1);
        }
        private static int BinaryRecursive_Func(int[] array, int element, int left, int right)
        {         
            int mid = left + (right - left) / 2;
            if (array[left] == element)
                return left;
            if(left > right)
                return badElement;
            if (array[mid] >= element)
                return BinaryRecursive_Func(array, element, left, mid - 1);
            else
                return BinaryRecursive_Func(array, element, mid + 1, right);
        }
        // прыжками
        public static int JumpsInOrderedArray(int[] array, int element)
        {
            if (array.Length == 0)
                return badElement;
            int sqrt = (int)Math.Sqrt(array.Length);
            index = 0;
            int length = array.Length, jump = sqrt;
            while (array[Math.Min(jump, length) - 1] < element)
            {
                index = jump;
                jump += sqrt;
                if (index >= length)
                    return badElement;
            }
            while (index < jump && array[index] < element)
            {
                index++;
            }
            if (array[index] == element)
                return index;
            return badElement;
        }
    }
}
