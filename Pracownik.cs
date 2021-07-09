using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        public string Position { get; set; }
        public string NameSurname { get; set; }
        public int WorkExp { get; set; }
        public int Salary { get; set; }
        public string Adress { get; set; }
        public int Id { get; set; }



        public Person(string position, string name, int exp, int salary, string adress)
        {
            Position = position;
            NameSurname = name;
            WorkExp = exp;
            Salary = salary;
            Adress = adress;

        }

    }
}