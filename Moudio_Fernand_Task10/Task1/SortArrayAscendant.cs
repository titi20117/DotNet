namespace Task1
{
    public delegate bool SortingMethod<T>(T x1, T x2);
    public class SortArrayAscendant<T>
    {
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
        }
    }
}