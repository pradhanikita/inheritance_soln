using System;

namespace inheritance_soln
{
    class Person
    {
       public string name;
       public void task()
        {
        Console.WriteLine("Hello World!");

        }
}
    class Nikita:Person
    {
        public void getname()
        {
            Console.WriteLine("My name is " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Nikita nikita = new Nikita();
            nikita.name = "Nikita";
            nikita.task();

            nikita.getname();

            Console.ReadLine();
        }
    }
}
