using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataType
            string name = "shubham";
            int number = 5;
            Console.WriteLine($"Name:{name}");
            Console.WriteLine(number);

            //implicit conversion
            decimal d1 = number;
            Console.WriteLine(d1);

            //explicit conversion
            char c1 = '1';
            int num2 = (int)c1;
            Console.WriteLine(num2);

            //conversion with helpers class"cnvert"
            string test = "12";
            int num3 =Convert.ToInt32(test);
            Console.WriteLine(num3);

            //check a length
            string name1 = "check code length";
            int length = name1.Length;
            Console.WriteLine($"Length:{length}");

            //Returns a new string that is a substring of the original string, starting from the specified index.
            string word = "Hello shubham";
            string name2 = word.Substring(6);
            Console.WriteLine($"Substring:{name2}");

            //ToUpper and ToLower
            string upperCaseText = word.ToUpper();
            string lowerCaseText = word.ToLower();
            Console.WriteLine($"Upper Case Text:{upperCaseText}");
            Console.WriteLine($"Lower Case Text:{lowerCaseText}");

            //Split word
            string names = "shubham,sam,Abhishek,Raj";
            string[] name5 = names.Split(',');
            Console.WriteLine(name5);
            //(not getting output:System.String[])

            //Trim word
            string text = "   Hello, World!   ";
            string trimmedText = text.Trim();
            Console.WriteLine(trimmedText);

            //StartsWith and EndsWith
            string test1 = "CD Team";
            bool startsWithword = test1.StartsWith("CD");
            bool endsWithWord = test1.EndsWith("Team");
            Console.WriteLine($"\n{startsWithword}");
            Console.WriteLine(endsWithWord);

            //Concatenation of string
            string firstname = "Shubham";
            string lastname = "M";
            string fullname=firstname+" "+lastname;
            Console.WriteLine($"\n{fullname}");

            var num = "1";
            Console.WriteLine(num);







        }
    }
}
