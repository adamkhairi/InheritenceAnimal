using System;

namespace Animal
{
    public class Animals
    {
        public string name;
        public int age;

        public Animals(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void eat()
        {
            Console.WriteLine("I Eat somthing !");
        }

        public void say()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}