﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student (25);
            student.SetFirstName("Anush");
            student.LastName = "Anush"; // set
            Console.WriteLine(student.LastName); // get
            student.Age = 25;
            Console.WriteLine(student.Age);
            


            Console.WriteLine(Example.className);
        }
    }
}
