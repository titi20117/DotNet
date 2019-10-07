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
            MyString myString = new MyString("Hello World");
            MyString myString2 = new MyString("Fernand Moudio");

            Console.WriteLine(myString);

            //Добавление
            MyString sum = myString + myString2;
            Console.WriteLine("добавление строку в конце текущего : {0}", sum);
            
            //Удаление
            MyString subMyString = new MyString("World");
            MyString del = myString - subMyString;
            Console.WriteLine("Удаление подстроку из текущей строки : {0}", del);
            
            //Сравнение
            MyString aStr = new MyString("Hello orld");
            Console.WriteLine(myString == null);
            Console.ReadKey();
        }

        public class MyString
        {
            private char[] firstTextToArrayChar;

            public MyString(string firstText)
            {
                this.firstTextToArrayChar = firstText.ToCharArray();
            }
          
            public static MyString operator +(MyString obj, MyString obj2)
            {
                MyString myString = new MyString("");
                char[] charArray = new char[obj.firstTextToArrayChar.Length + obj2.firstTextToArrayChar.Length];
                obj.firstTextToArrayChar.CopyTo(charArray, 0);
                obj2.firstTextToArrayChar.CopyTo(charArray, obj.firstTextToArrayChar.Length);
                myString.firstTextToArrayChar = charArray;
                return myString;
            }
            public static MyString operator -(MyString obj, MyString obj2)
            {
                string objStr = obj.ToString();
                string obj2Str = obj2.ToString();
                string result;
                result = objStr.Replace(obj2Str, "");
                return new MyString(result);
            }
            public static bool operator ==(MyString obj, MyString obj2)
            {
                if ((object)obj == null || (object)obj2 == null || (obj.firstTextToArrayChar.Length != obj2.firstTextToArrayChar.Length))
                    return false;
  
                for(int i = 0; i <  obj.firstTextToArrayChar.Length; i++)
                {
                    if (obj.firstTextToArrayChar[i] != obj2.firstTextToArrayChar[i])
                        return false;
                }
                return true;
            }

            public static bool operator !=(MyString obj, MyString obj2)
            {
                return !(obj == obj2);
            }

            public override string ToString()
            {
                return new string(firstTextToArrayChar);
            }
        }
    }
}
