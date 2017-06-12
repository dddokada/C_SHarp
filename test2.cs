using System;
using System.Diagnostics;

class AttributeTest
{
    static void Main()
    {
        double[] array = new double[] { 9, 4, 5, 2, 7, 1, 6, 3, 8 };
        BubbleSort(array);
        Output(array);
    }

    /// <summary>
    /// バブルソートを行う。
    /// </summary>
    static void BubbleSort(double[] array)
    {
        int n = array.Length - 1;

        for (int i = 0; i < n; ++i)
        {
            for (int j = n; j > i; --j)
                if (array[j - 1] > array[j])
                    Swap(ref array[j - 1], ref array[j]);

            IntermediateOutput(array); // ソートの途中段階のデータを表示。
        }
    }

    static void Swap(ref double x, ref double y)
    {
        double tmp = x;
        x = y;
        y = tmp;
    }

    /// <summary>
    /// 配列の内容をコンソールに表示する。
    /// </summary>
    static void Output(double[] array)
    {
        foreach (double x in array)
        {
            Console.Write("{0} ", x);
        }
        Console.Write("\n");
    }

    /// <summary>
    /// SHOW_INTERMEDIATE というシンボルが定義されているときのみ
    /// 配列の内容をコンソールに表示する。
    /// </summary>
    [Conditional("SHOW_INTERMEDIATE")]
    static void IntermediateOutput(double[] array)
    {
        Output(array);
    }
}