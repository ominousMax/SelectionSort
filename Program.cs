using System;

namespace SelectionSort
{
    public static class Sorter
    {
        public static void Main()
        {
            SelectionSort(new int[] { 7, 6, 5, 4, 3, 2, 1 });
            RecursiveSelectionSort(new int[] { 7, 6, 5, 4, 3, 2, 1 });
        }

        public static void SelectionSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), "Array can not be null.");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                int j, t = i, temp = array[i];
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        array[i] = array[j];
                        t = j;
                    }
                }

                array[t] = temp;
            }
        }

        public static void RecursiveSelectionSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), "Array can not be null.");
            }

            int reqIndex = -1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    reqIndex = i;
                    break;
                }
            }

            if (reqIndex >= 0)
            {
                int temp = array[reqIndex], t = 0;
                for (int j = reqIndex; j < array.Length; j++)
                {
                    if (array[reqIndex] > array[j])
                    {
                        array[reqIndex] = array[j];
                        t = j;
                    }
                }

                array[t] = temp;
            }

            if (reqIndex != -1)
            {
                RecursiveSelectionSort(array);
            }
        }
    }
}

