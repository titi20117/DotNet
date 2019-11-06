using System;

namespace Task3
{
    public class SortingEventArgs<T> : EventArgs
    {
        public T[] Arr { get; }

        public SortingEventArgs(T[] arr)
        {
            if (arr != null)
            {
                this.Arr = arr;
            }
            else
            {
                throw new ArgumentException("arr can't be null");
            }
        }
    }
}