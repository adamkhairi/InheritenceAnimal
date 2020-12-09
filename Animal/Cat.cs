namespace Animal
{
    public class Cat : Animals
    {
        public double poid;
        
        public Cat(string name, int age,double poid) : base(name, age)
        {
            this.poid= poid;
        }
        
    }
}