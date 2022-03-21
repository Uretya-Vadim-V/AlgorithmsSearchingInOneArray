using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace AlgorithmsSearchingInOneArray
{
    class Ex
    {
        public static void Unification(Excel.Worksheet sheet, string x, string y, int u, int v, string text)
        {
            sheet.get_Range(x, y).Merge(Type.Missing);
            sheet.Cells[u, v] = text;
        }
        public static void CreateTable(Excel.Worksheet sheet, int textSize, string fontName, bool alignment, int collumnSize, bool borders, bool interiorColor)
        {
            Excel.Range range = sheet.get_Range("A1", "N9");
            Unification(sheet, "C1", "H1", 1, 3, "Среднний случай");
            Unification(sheet, "I1", "N1", 1, 9, "Худший случай");
            Unification(sheet, "C2", "D2", 2, 3, "Неупорядочный массив");
            Unification(sheet, "E2", "H2", 2, 5, "Упорядочный массив");
            Unification(sheet, "I2", "J2", 2, 9, "Неупорядочный массив");
            Unification(sheet, "K2", "N2", 2, 11, "Упорядочный массив");
            Unification(sheet, "C3", "N3", 3, 3, "Время работы в тиках");
            Unification(sheet, "A2", "A4", 2, 1, "Элемент");
            Unification(sheet, "B2", "B4", 2, 2, "Длина");
            for (int i = 3; i < 15; i += 6)
            {
                sheet.Cells[4, i] = "Линейный ";
                sheet.Cells[4, i + 1] = "Линейный с барьером";
                sheet.Cells[4, i + 2] = "Быстрый линейный";
                sheet.Cells[4, i + 3] = "Бинарный итерационный";
                sheet.Cells[4, i + 4] = "Бинарный рекурсивный";
                sheet.Cells[4, i + 5] = "Прыжками";
            }
            sheet.get_Range("C4", "N4").Columns.EntireColumn.ColumnWidth = collumnSize;
            range.Cells.Font.Size = textSize;
            range.Cells.Font.Name = fontName;
            if (alignment)
            {
                range.HorizontalAlignment = Excel.Constants.xlCenter;
                range.VerticalAlignment = Excel.Constants.xlCenter;
            }
            if (borders)
            {
                range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            }
            if (interiorColor)
            {
                sheet.get_Range("A1", "N1").Cells.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(221, 217, 195));
                sheet.get_Range("A2", "B9").Cells.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(221, 217, 195));
                sheet.get_Range("C2", "N2").Cells.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(250, 191, 143));
                sheet.get_Range("C4", "N4").Cells.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(253, 233, 217));
                sheet.get_Range("C5", "N9").Cells.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(234, 241, 221));
            }
        }
        public static void CreaterGraphic(Excel.Worksheet sheet)
        {
            Excel.ChartObjects chartsobjrcts = (Excel.ChartObjects)sheet.ChartObjects(Type.Missing);
            Excel.ChartObject chartsobjrct1 = chartsobjrcts.Add(10, 200, 500, 300);
            chartsobjrct1.Chart.ChartWizard(sheet.get_Range("B4", "H9"), Excel.XlChartType.xlLine, 2, Excel.XlRowCol.xlColumns,
                    Type.Missing, -1, true, "Средний случай", "Длина массива", "Время работы");
            Excel.ChartObject chartsobjrct2 = chartsobjrcts.Add(520, 200, 500, 300);
            chartsobjrct2.Chart.ChartWizard(sheet.get_Range("I4", "N9"), Excel.XlChartType.xlLine, 2, Excel.XlRowCol.xlColumns,
                    Type.Missing, -1, true, "Худший случай", "Длина массива", "Время работы");
        }
    }
}
