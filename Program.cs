using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Pokaz liste");
                Console.WriteLine("2. Dodaj");
                Console.WriteLine("3. Usun");

                Console.WriteLine("0. Wyjscie");

                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            Load();
                            break;


                        case "2":
                            Console.Clear();


                            Console.WriteLine("Stanowisko: ");
                            string position = Console.ReadLine();
                            Console.WriteLine("Imie & Nazwisko: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Doświadczenie w firmie: ");
                            string exp = Console.ReadLine();
                            Console.WriteLine("Pensja: ");
                            string salary = Console.ReadLine();
                            Console.WriteLine("Adres zamieszkania: ");
                            string adress = Console.ReadLine();
                            Person Person = new Person(position, name, int.Parse(exp), int.Parse(salary), adress);

                            Data data1 = new Data();
                            data1.AddEmployee(Person);


                            break;

                        case "3":
                            Console.Clear();
                            Load();
                            Console.WriteLine("Podaj ID: ");
                            string nr = Console.ReadLine();
                            Data data = new Data();
                            data.Delete(int.Parse(nr));
                            Console.Clear();
                            Load();
                            break;
                    }

                    Console.ReadKey();
                }
            }
        }



        static void Load()
        {
            Data Data = new Data();
            List<Person> employes = Data.EmployesList().ToList();
            foreach (Person person in employes)
            {
                Console.WriteLine($"ID: {person.Id} : {person.NameSurname} {person.Position} {person.Salary} {person.WorkExp} {person.Adress}");
            }
        }

    }
}