using System;
using System.Collections.Generic;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Collections");

            var Cities = new List<string>();

            Cities.Add("Mumbai");
            Cities.Add("Pune");
            Cities.Add("Banglore");
            Cities.Add("Hydrabad");
            Cities.Add("Delhi");

            foreach(var city in Cities)
            {
                Console.Write(city + " ");
            }

            Cities.ForEach(c => Console.WriteLine(c));

            var Students = new List<Student>
            {
                new Student(){Name="Shubham", RollNumber=1},
                new Student(){Name="Prashan", RollNumber=2},
                new Student(){Name="Kavish", RollNumber=3},
            };

            foreach(Student stud in Students)
            {
                if (stud.Name.Contains("Kavish"))
                    Console.WriteLine(stud.Name + " chutiya hai");
                Console.WriteLine(stud.RollNumber + " " + stud.Name);
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }
    }
}

