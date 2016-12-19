using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Student
    {

        public Student(int age)
        {
            Age = age;
            Email = string.Empty;
            phone = string.Empty;
        }

        public Student(int age, string firstName, string lastName) : this(age)// myus constructor@ vonc 
        // vor te ogtagortecinq, skzbum ashxatacnum e arajin constructor@ nor erkrord
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private string firstName = string.Empty;
        private string lastName = string.Empty;
        //private string Email; comment qani vor avtoproperty enq sargel
        private string phone;
        private int birthYear;


        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email // avtoproperty e stextum, kareli e mi toxum grel public string Email {get; set}
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - birthYear;
            }

            set
            {
                birthYear = DateTime.Now.Year - value;
            }
        }

        public string Phone { get; private set; } // we can only read but not set phone number 

        public bool IsAdult
        {
            get
            {
                return Age > 18;
            }
        }




        class Classroom
        {
            string name;
            Student[] students;
        }

        class Example
        {
            public Example(int n)
            {
                this.n = n;
            }

            public int N { get; set; }

            public void ChangeN(int N)
            {
                N = n;
            }

            public static string staticName = "Example";


            public const string className = "Example";
            public readonly int n;
        }



    }
    }
