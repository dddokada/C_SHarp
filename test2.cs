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
    /// �o�u���\�[�g���s���B
    /// </summary>
    static void BubbleSort(double[] array)
    {
        int n = array.Length - 1;

        for (int i = 0; i < n; ++i)
        {
            for (int j = n; j > i; --j)
                if (array[j - 1] > array[j])
                    Swap(ref array[j - 1], ref array[j]);

            IntermediateOutput(array); // �\�[�g�̓r���i�K�̃f�[�^��\���B
        }
    }

    static void Swap(ref double x, ref double y)
    {
        double tmp = x;
        x = y;
        y = tmp;
    }

    /// <summary>
    /// �z��̓��e���R���\�[���ɕ\������B
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
    /// SHOW_INTERMEDIATE �Ƃ����V���{������`����Ă���Ƃ��̂�
    /// �z��̓��e���R���\�[���ɕ\������B
    /// </summary>
    [Conditional("SHOW_INTERMEDIATE")]
    static void IntermediateOutput(double[] array)
    {
        Output(array);
    }
}