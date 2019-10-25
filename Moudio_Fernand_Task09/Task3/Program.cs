using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "is good to know something new, i like to play a football, go to the training, listen music" +
                "with my friends";
            RegexDemo regexDemo = new RegexDemo();
            regexDemo.Demo();
            Console.ReadKey();
        }
    }

    public class RegexDemo
    {
        public void Demo()
        {
            Regex regex = new Regex(@"\d+");

            Match match = regex.Match("Dot 55 Perls 777");
            while (match.Success)
            {
                Console.WriteLine(match.Value);
                match = match.NextMatch();
            }

            string sentence = "10 cats, 20 dogs, 40 fish and 1 programmer.";
            string[] digits = Regex.Split(sentence, @"\w+");
            foreach (string value in digits)
            {
                int number;
                if (int.TryParse(value, out number))
                {
                    Console.WriteLine(value);
                }
            }


            string pattern = @"\b(\w+?)\s\1\b";
            string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";

            foreach (Match match1 in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("{0} (duplicates '{1}') at position {2}",
                    match1.Value, match1.Groups[1].Value, match1.Index);
            }
        }
    }
}
