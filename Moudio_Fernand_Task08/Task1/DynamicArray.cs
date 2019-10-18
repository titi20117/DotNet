using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DynamicArray <T>
    {
        private int capacity;
        private int nbElts;
        private T[] array;

        public void NbreElts() 
        {
            nbElts = array.Length;        
        }
        //1
        public DynamicArray ()
        {
            this.capacity = 8;
            array = new T[this.capacity];
        }

        //2
        public DynamicArray (int capac)
        {
            this.capacity = capac;
            array = new T[this.capacity];
        }

        //3
        public DynamicArray (T[] dynArr)
        {
            array = dynArr;
        }

        //4
        public void Add (T element)
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
        public void AddRange (T[] arr)
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

        public bool Remove (T el)
        {
            bool result = true;
            for (int i = 0; i < array.Count(); i++)
            {
                T item = (T)array[i];
                if(item.Equals(el))
                {

                }
            }
            return result;
        }

        public T GetElementArray (int index)
        {
            if (index < 0 || index <= nbElts)
            {
                return default(T);
            }
            return array[index];
        }
    }
}
