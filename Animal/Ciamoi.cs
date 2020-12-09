namespace Animal
{
    public class Ciamoi : Cat
    {
        public double size;

        public Ciamoi(string name, int age, double poid) : base(name, age, poid)
        {
            this.poid = poid;
        }
    }
}