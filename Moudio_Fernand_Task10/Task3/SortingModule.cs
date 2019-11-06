using System;
using System.Threading;

namespace Task3
{
    public delegate bool SortingMethod<T>(T x1, T x2);
    public class SortingModule<T>
    {
        public event EventHandler<SortingEventArgs<T>> SortingFinished;

        public void CustomSort(T[] arr, SortingMethod<T> sortingMethod)
        {
            bool isSorted = false;
            T temp;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = arr.GetLowerBound(0); i < arr.GetUpperBound(0); i++)
                {
                    if (sortingMethod(arr[i], arr[i + 1]))
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        isSorted = false;
                    }
                }
            }
            SortingFinished?.Invoke(this, new SortingEventArgs<T>(arr));
        }

        public void RunSortInNewThread(T[] arr, SortingMethod<T> sortingMethod)
        {
            ThreadStart thStart = new ThreadStart(() => CustomSort(arr, sortingMethod));
            Thread th = new Thread(thStart);
            th.Start();
        }
    }
}