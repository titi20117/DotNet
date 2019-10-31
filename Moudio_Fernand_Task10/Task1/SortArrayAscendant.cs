﻿using System;

namespace Task1
{
    public class SortArrayAscendant
    {
        private string[] array;
        public delegate void Operation(string[] arr);
        public SortArrayAscendant(string[] arr)
        {
            this.array = arr;
        }
        public string[] Array
        {
            get { return array; }
        }

        public void SortOperation(string[] arr, Operation action)
        {
            action(arr);
        }
        public void GetArrayLengthAscending(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Length > arr[j].Length)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        private bool SetReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }

        public void GetArrayWordAscending(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (SetReOrder(arr[i], arr[j]))
                        {
                            string s = arr[i];
                            arr[i] = arr[j];
                            arr[j] = s;
                        }
                    }
                }
            }
        }

    }
}