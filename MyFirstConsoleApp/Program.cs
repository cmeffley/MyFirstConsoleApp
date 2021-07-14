using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            //get data from a user
            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();

            //name = "7";

            //32 bit signed numbers
            int favoriteNumber = -6;
            //64 bit signed numbers
            long reallyBigNumber = 9_223_372_036_854_775_806;

            //16 bit signed numbers
            short smallerNumbers = 32_000;

            //stuff with decimals
            double accountBalance = 0.57;
            //decimal accountBalance = 0.57m;

            //var is shorthand for the real type
            //type inference (stuff on the right side of equals)
            var myStuff = 5 * 5;
            //this still won't work
            //myStuff = "";

            //bool is for boolean
            bool isTeaching = true;

            //datetime is for holding.... datetime
            var today = new DateTime(2021, 7, 13);
            today = DateTime.Today;

            // var students = new string[5]; //array can only ever have 5 strings(in this example) in it

            // new keyword = instance / instatiation 
            //lists        List of string
            var students = new List<string>();

            students.Add("Hunter");
            students.Add("Rob");
            students.Add("Jimbo");

            students.Remove("Jimbo");

            for(var i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            //more idiomatic
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            //csharp one equal(=) for set and two for equality



        }
    }
}
