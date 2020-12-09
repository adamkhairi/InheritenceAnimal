namespace Animal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cat rex = new Cat("rex", 3, 7.5);
            rex.eat();
            rex.say();

            Ciamoi caat = new Ciamoi("caat", 4, 2);
            caat.say();
        }
    }
}