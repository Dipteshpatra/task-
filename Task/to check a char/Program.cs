using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_check_a_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdefgh";
            Char value = 'c';
            Boolean result = str.Contains(value);
            Console.WriteLine("is c char avilable in the string-"+ result);
        }
    }
}
