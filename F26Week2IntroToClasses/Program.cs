namespace F26Week2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(101, "Laptop", 1200);

            Product p3 = new();
            Product p4 = new(102, "Mobile", 2000);

            var p5 = new Product();
            //var p6 = new();
        }
    }
}
