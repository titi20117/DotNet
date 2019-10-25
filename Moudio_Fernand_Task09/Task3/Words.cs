using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    public class Words<T> : IEnumerable<string>
    {
        private string text;
        public List<string> TextToArray { get { return GetArray(); } }
        public int CountRepeatingWords{ get { return 5; } }
        
        
        public Words(string someText)
        {
            text = someText;
        }

        private List<string> GetArray ()
        {
            List<string> myList = new List<string>();
            Regex regex = new Regex(@"\w+");
            Match match = regex.Match(text.ToLower());
            int i = 0;
            while(match.Success)
            {
                myList.Add(match.Value);
                match = match.NextMatch();
                i++;
            }
            return myList;
        }

        public int GetCountWord(Words<string> dynWord)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            List<string> val = new List<string>();
            foreach (var tm in TextToArray)
                val.Add(tm);
            int result = 0;
            foreach(var item in val)
            {
                foreach(var el in dynWord)
                {
                    if (item == el)
                    {
                        result++;
                        val.Remove(item);
                    }
                }
                keyValuePairs.Add(item, result);
            }
            return result;
        } 
        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < TextToArray.Count(); i++)
            {
                yield return TextToArray[i];

                if (i > TextToArray.Count())
                    yield break;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
