using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private int capacity;
        private int nbElts;
        private T[] array;

        public int Length { get { return this.nbElts; } }
        public int Capacity { get { return this.capacity; } }
        //1
        public DynamicArray()
        {
            this.capacity = 8;
            array = new T[this.capacity];
        }

        public DynamicArray(IEnumerable<T> ts)
        {
            this.capacity = ts.Count();
            array = new T[ts.Count()];
            for (int i = 0; i < ts.Count(); i++) {
                array[i] = ts.ElementAt(i);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];

                if (i == 5)
                    yield break;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //2
        public DynamicArray(int capac)
        {
            this.capacity = capac;
            array = new T[this.capacity];
        }

        //3
        public DynamicArray(T[] dynArr)
        {
            array = dynArr;
        }

        //4
        public void Add(T element)
        {
            if (nbElts >= capacity)
            {
                capacity *= 2;
                T[] CloningArr = new T[capacity];
                for (int i = 0; i < array.Length; i++)
                {
                    CloningArr[i] = array[i];
                }
                array = CloningArr;
            }
            array[nbElts] = element;
            nbElts++;
        }

        //5
        public void AddRange(T[] arr)
        {
            if (nbElts >= capacity)
            {
                capacity += arr.Length;
                T[] CloningArr = new T[capacity];
                for (int i = 0; i < array.Length; i++)
                {
                    CloningArr[i] = array[i];
                }
                array = CloningArr;
            }
            foreach (var el in arr)
            {
                array[nbElts] = el;
                nbElts++;
            }
        }

        public bool Remove(T el)
        {
            for (int i = 0; i < array.Count(); i++)
            {
                T item = (T)array[i];
                if (item == null)
                {
                    return false;
                }
                if (item.Equals(el))
                {
                    array[i] = default(T);
                    T temp = array[i];
                    for (int j = i; j < array.Count() - 1; j++)
                    {
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                    break;
                }
            }
            return true;
        }

        public void Insert(T el, int index)
        {
            T[] newArr = new T[capacity];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }

            if (index < 0 || index >= nbElts)
            {
                throw new ArgumentOutOfRangeException("index", "Выход за границу массива");
            }
            else
            {
                for (int i = 0; i < newArr.Length; i++)
                {
                    if (index == i)
                    {
                        if (nbElts >= capacity)
                        {
                            capacity *= 2;
                            T[] CloningArr = new T[capacity];
                            for (int k = 0; k < array.Length; k++)
                            {
                                CloningArr[k] = array[k];
                            }
                            array = CloningArr;
                        }
                        nbElts++;

                        array[i] = el;
                        for (int j = i + 1; j < newArr.Length - 1; j++)
                        {
                            array[j] = newArr[j - 1];
                        }
                    }
                }
            }
        }

        public T GetElementArray(int index)
        {
            if (index < 0 || index >= nbElts)
            {
                throw new ArgumentOutOfRangeException("index", "Выход за границу массива");
            }
            return array[index];
        }
    }   
}
