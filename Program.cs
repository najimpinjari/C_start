using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace _4_StringType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // veriable declared name = jayesh 123 //
            // and finding a length of world or anything in parenthises //

            string name = "jayesh 123";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);

            // for clear left side spaces , right side spaces and both side spaces from veriable//
            string name1 = "     1jayesh      ";
            Console.WriteLine(name1);
            Console.WriteLine(name1.TrimStart());
            Console.WriteLine(name1.TrimEnd());
            Console.WriteLine(name1.Trim());

            // fro converting veriable to capital and small latter //
            Console.WriteLine(name1.ToUpper());
            Console.WriteLine(name1.ToLower());

            string j = "\"najim\"";
            Console.WriteLine(j);

            // spaces and next line functions //


            string name4 =  "jayesh malache";
            Console.WriteLine(name4);
            //it's givss you one space in betweeen //


            string v = "jayesh\tmalache";
            Console.WriteLine(v);
            //it's gives you three spaces in between the sentence//

            string b = "jayesh\nmalache";
            Console.WriteLine(b);
            // when you add \n in middle of sentence hi gives the output in next line becose of backspash n //

            // path - for finding backslash meaning so you can add in string @ simbal //
            // ex this is a randam path  ;  E:\JAVA FILES\my java nots

            // you can not add direcly you need to add attheret @ simbal in frout of the path //
            string path1 = @"E:\JAVA\FILES\my\java\\nots";
            Console.WriteLine(path1);

            //concat function -1cncat first //

            string one = "jayesh";
            string two = "bapu";
            string three = "malache";
            string fullname1 = one + two + three;
            Console.WriteLine(fullname1);
            fullname1 = string.Concat(one,two , three);
            // concat function -2- join function //
            fullname1 = string.Join(" ", one, two, three);
            Console.WriteLine (fullname1);
            // concat function --3 farmat function//
            fullname1 = string.Format("fullname {0} {1} {2}", one, two, three);
            Console.WriteLine(fullname1);

            // string interpolation //
            fullname1 = $"fullname : {one} {two} {three}";
            Console.WriteLine(fullname1);


            //datatype convention //

            int i = 10, j = 20;
            Console.WriteLine(i + j);















            // string interpolation
            fullName = $"Full Name : {firstName} {middleName}\t, {lastName}";
            Console.WriteLine(fullName);

            fullName = $"My Son Name Is : {firstName}";
            Console.WriteLine(fullName);

            Console.ReadLine();
        }
    }
}
