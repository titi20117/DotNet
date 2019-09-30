using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public class Stringer
    {
        public static string[] GetArrayString( string input)
        {
            return input.Split(" ,.?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
