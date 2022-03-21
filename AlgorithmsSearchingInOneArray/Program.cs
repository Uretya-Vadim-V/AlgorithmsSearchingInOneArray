using System;
using System.Collections.Generic;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace AlgorithmsSearchingInOneArray
{
    class Program
    {
        // время работы поиска индекса элемента
        static double timeWork;
        static Random random = new();
        // Средний случай заполнения массива, есть искомый элемент
        static int[] Average(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                array[i] = length + 1;// для наглядности работы
            }
            return array;
        }
        // Худший вариант заполнения массива, нет искомого элемента
        static int[] Worst(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                array[i] = 0;// для наглядности работы
            }
            return array;
        }
        private static void Stopwatch(Func<int[], int, int> method,int[] array, int number)
        {
            // секундомер
            Stopwatch stopwatch = new();
            timeWork = 0;
            stopwatch.Reset();
            stopwatch.Start();
            method(array, number);
            stopwatch.Stop();
            // время работы алгоритма в тиках
            timeWork += stopwatch.ElapsedTicks;
        }
        // создание excel  файла
        static Excel.Application excel = new();
        static Excel.Workbook workBook = excel.Workbooks.Add(Type.Missing);
        static Excel.Worksheet sheet = (Excel.Worksheet)excel.Worksheets.get_Item(1);
        static int y = 5, x = 3;
        static void Finder(int[] array, int element)
        {
            // линейный
            Stopwatch(Search.LinearInUnorderedArray, array, element);
            Console.WriteLine($"Время работы линейного поиска: {timeWork}");
            sheet.Cells[y, x] = timeWork;
            // линейный с барьером
            int[] arrayWithBarrier = new int[array.Length + 1];
            array.CopyTo(arrayWithBarrier, 0);
            arrayWithBarrier[array.Length] = element;
            Stopwatch(Search.LinearWithBarrierInDisorderedArray, arrayWithBarrier, element);
            Console.WriteLine($"Время работы линейного с барьером поиска: {timeWork}");
            sheet.Cells[y, x + 1] = timeWork;
            // сортируем массив
            Array.Sort(array);
            // быстрый линейный
            Stopwatch(Search.FastLinearInOrderedArray, array, element);
            Console.WriteLine($"Время работы быстрого линейного поиска: {timeWork}");
            sheet.Cells[y, x + 2] = timeWork;
            // бинарный итерационный
            Stopwatch(Search.BinaryIterative, array, element);
            Console.WriteLine($"Время работы бинарного итерационного поиска: {timeWork}");
            sheet.Cells[y, x + 3] = timeWork;
            // бинарный рекурсивный
            Stopwatch(Search.BinaryRecursive, array, element);
            Console.WriteLine($"Время работы бинарного рекурсивного поиска: {timeWork}");
            sheet.Cells[y, x + 4] = timeWork;
            // прыжками
            Stopwatch(Search.JumpsInOrderedArray, array, element);
            Console.WriteLine($"Время работы прыжкогого поиска: {timeWork}");
            sheet.Cells[y, x + 5] = timeWork;
            x = 3;
        }
        static void Main(string[] args)
        {
            List<int> n = new List<int> { 1000000, 2000000, 3000000, 4000000, 5000000 };
            sheet.Name = "График";
            // содание таблицы
            Ex.CreateTable(sheet, 12, "Times New Roman", true, 25, true, true);
            int q = 5;
            foreach (int k in n)
            {
                int[] pointsArray = new int[k];
                Average(pointsArray);// холостой прогон
                // элемент, индекс которого ищем
                int elementToFind = random.Next(0, k);
                Console.WriteLine($"------------------------------------------------------\nИскомый элемент: {elementToFind}");
                sheet.Cells[q, 1] = elementToFind;
                sheet.Cells[q, 2] = k;
                q++;
                Console.WriteLine($"▬▬▬▬▬▬▬▬ Средний случай ▬▬▬▬▬▬▬▬\n▬▬▬▬▬▬▬▬     {k}    ▬▬▬▬▬▬▬▬");
                Finder(Average(pointsArray), elementToFind);
                x += 6;
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine($"▬▬▬▬▬▬▬▬ Худший случай ▬▬▬▬▬▬▬▬\n▬▬▬▬▬▬▬▬     {k}    ▬▬▬▬▬▬▬▬");
                Finder(Worst(pointsArray), elementToFind);
                y++;
            }
            // создание графика
            Ex.CreaterGraphic(sheet);
            // сохранение таблицы в папку "Документы" на диск "C"
            excel.Application.DisplayAlerts = false;
            excel.Application.ActiveWorkbook.SaveAs("Graphic_5.xlsx");
            workBook.Save();
            excel.Visible = true;
        }
    }
}
