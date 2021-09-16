using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    class Person
    {

        //public int age { get; set; }

        //public string name { get; set; }

        //public Person()
        //{
        //    Console.WriteLine("Empty person created");

        //}

        //public Person(string name, int age)
        //{
        //    this.name = name;
        //    this.age = age;
        //    Console.WriteLine("{0} created. Age: {1}" + name + age);
        //}


        public string name { get; set; }
        public int age { get; set; }
        public Person(string name, int age)                             // constructor with string and int parameter
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Name of person : {0}  and Age of Person: {1}" + name + age);
        }
        public Person()                                                  // constructor with no parameter
        {
            Console.WriteLine("Person : ");
        }




    }



    static void Main(string[] args)
    {
        Person person = new Person();
        Person Akhi = new Person(age: 21, name: "Akhi");

        Console.WriteLine("Enter age for Akhi: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter name for Person: ");
        string name = Console.ReadLine();

        person.age = age;
        person.name = name;
        Console.WriteLine("Person has Name: {0} and Age: {1}" + person + name + age);


        //Person person = new Person(name, age);                       // call constructor with string and int parameter
        //Console.WriteLine(" Name of Person : {0} and Age: {1}" + name + age);

        //Person age = new age();                                   // call constructor with int parameter

        Console.ReadLine();
    }



    
    
}
