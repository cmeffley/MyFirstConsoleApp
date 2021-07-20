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
            //whatever someone types in, will be set to name, must be string because that's what I declared
            name = Console.ReadLine();

            //console.log(`my name is ${name}); string interpolation in JS
            Console.WriteLine($"Hello, {name}"); //same as above, but in C sharp
            Console.WriteLine("Hello, " + name); //string concatenation

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

            if (name == "Nathan")
            {
                Console.WriteLine("Hey it me");
            }
            else
            {
                Console.WriteLine("Not me");
            }

            //ternary (not technically control flow like the if statement above)
            var greeting = name == "Nathan" ? "It is you." : "It is not you";

            //anonymous types
            var nathan = new { Name = "Nathan", IsTeacher = true };

            //nathan.Name = "Steve"; can't change things in the object in anonymous types (immutable)

            //objects break the rules sometimes because of being a reference type
            object animalType = "Dog";  //object wraps "around" the string and the object changes (I think)
            animalType = 45;

            //boxing moves values to the heap
            if (animalType.ToString() == "Dog")
            {
            } 
        }
    }
}
