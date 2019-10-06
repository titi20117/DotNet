using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString myString = new MyString();
            MyString myString2 = new MyString();

            myString.firstText = "hello world";
            myString2.firstText = " Fernand Moudio";
            //Добавление
            MyString sum = myString + myString2;
            Console.WriteLine("добавление строку в конце текущего : {0}", sum);
            //Удаление
            MyString subMyString = new MyString();
            subMyString.firstText = "world";
            MyString del = myString - subMyString;
            Console.WriteLine("Удаление подстроку из текущей строки : {0}", del);
            //Сравнение
            MyString aStr = new MyString();
            aStr.firstText = "hello world";
            MyString comp = myString == myString2;
            MyString comp2 = myString == aStr;
            if(comp.GetTest())
            {
                Console.WriteLine("Объект равный");
            }
            else
            {
                Console.WriteLine("Объект неравный");
            }
            if (comp2.GetTest())
            {
                Console.WriteLine("Объект равный");
            }
            else
            {
                Console.WriteLine("Объект неравный");
            }
            Console.ReadKey();
        }

        public class MyString
        {
            public string firstText { get; set; }
            public char[] firstTextToArrayChar { get { return firstText.ToCharArray(); } }
            private bool test;

            public bool GetTest()
            {
                return test;
            }
            public static MyString operator +(MyString obj, MyString obj2) 
            {
                MyString myString = new MyString();
                myString.firstText = obj.firstText + obj2.firstText;
                return myString;
            }
            public static MyString operator -(MyString obj, MyString obj2)
            {
                MyString myString = new MyString();
                int n = obj.firstText.IndexOf(obj2.firstText);
                myString.firstText = obj.firstText.Remove(n, obj2.firstText.Length);
                return myString;
            }
            public static MyString operator ==(MyString obj, MyString obj2) 
            {
                MyString myString = new MyString();
                myString.test = obj.firstText == obj2.firstText;
                return myString; 
            }

            public static MyString operator !=(MyString obj, MyString obj2) 
            {
                MyString myString = new MyString();
                myString.test = obj.firstText != obj2.firstText;
                return myString;
            }

            public override string ToString()
            {
                return (String.Format("{0}", firstText));
            }
        }
    }
}
