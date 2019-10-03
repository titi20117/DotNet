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
            
            Console.Write("Введите текст : ");
            myString.firstText = Console.ReadLine();
            myString2.secondText = "world";
            myString2.firstText = "dsdsds";
            myString2.secondText = "fwfdzf";
            Console.WriteLine(myString + myString2);
            Console.WriteLine(myString.Equals(myString2));
            Console.ReadKey();
        }

        public class MyString
        {
            public string firstText { get; set; }
            public char[] firstTextToArrayChar { get { return firstText.ToCharArray(); } }
            public string secondText { get; set; }
            public char[] secondTextToArrayChar { get { return secondText.ToCharArray(); } }

            //override Eq (MyString ms1, MyString ms2);
            public static MyString operator +(MyString firstText, MyString secondText) 
            { 
                return firstText + secondText;
            }
            public static MyString operator -(MyString firstText, MyString secondText)
            {
                return firstText - secondText;
            }
            public override bool operator ==(MyString obj1, MyString obj2) 
            {
                if (obj1 == obj2)
                    return true;
                else
                    return false; 
            }
            public override bool operator !=(MyString obj1, MyString obj2) 
            {
                if (obj1 != obj2)
                    return true;
                else
                    return false;
            }
        }
    }
}
