using System;

namespace Animal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Cat rex = new Cat("rex", 3, 7.5,40);
            // rex.eat();
            // rex.say();
            //
            // Ciamoi caat = new Ciamoi("caat", 4, 2,45,45);
            // caat.say();
            Animals cat = new Animals("Catss",2,5,45);
            Console.WriteLine(cat.name);
            Console.WriteLine(cat.age);
            
            //    Can't Access neither Protected nor Private
            // Console.WriteLine(cat.weight);
            // Console.WriteLine(cat.leength);
        }
    }
}