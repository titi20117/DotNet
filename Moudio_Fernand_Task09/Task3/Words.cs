using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Words<T> : IEnumerable<string>
    {
        private string text;
        private string[] textToArray;
        public int CountRepeatingWords{ get { return 5; } }
        
        
        public Words(string someText)
        {
            text = someText;
            //textToArray = text.Split(text, "")
            for (int i = 0; i < text.Length; i++)
            {

            }
        }
        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < textToArray.Length; i++)
            {
                yield return textToArray[i];

                if (i > textToArray.Length)
                    yield break;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
