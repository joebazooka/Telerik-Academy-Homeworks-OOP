using System;
using System.Linq;
using System.Text;

namespace Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();

            str.Append("0123456789");

            Console.WriteLine(str.Substring(3,4));
        }
    }

    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            if (index + length > str.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Index and Length must be inside boundaries of StringBuilder.");
            }

            StringBuilder result = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                result.Append(str[i]);
            }
            
            return result;
        }
    }
}
