using System;

namespace Animal
{
    public class Animals
    {
        public string name;
        public int age;
        
        protected double weight;
        private double leength;

        public Animals(string name, int age, double weight,double leength)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.leength=leength;
        }
        public void showAn()
        {
            Animals cat = new Animals("Catss",2,5,45);
            Console.WriteLine(cat.name);
            Console.WriteLine(cat.age);
            //    Can Access both Private and Protected 

            Console.WriteLine(cat.weight);
            Console.WriteLine(cat.leength);
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