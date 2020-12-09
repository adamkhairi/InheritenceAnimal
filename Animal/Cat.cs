using System;

namespace Animal
{
    public class Cat : Animals
    {
        public double poid;


        public Cat(string name, int age, double weight, double leength,double poid) : base(name, age, weight, leength)
        {
            this.poid = poid;
        }

        public void show()
        {
            Cat cat = new Cat("Catss",2,5,45,5);
            Console.WriteLine(cat.name);
            Console.WriteLine(cat.age);
            Console.WriteLine(cat.weight);
            
            //    Can't Access Privat
            // Console.WriteLine(cat.leength);
        }
    }
}