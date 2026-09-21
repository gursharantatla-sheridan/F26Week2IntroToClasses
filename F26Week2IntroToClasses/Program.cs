namespace F26Week2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();

            p1.SetId(100);
            Console.WriteLine("p1.id = " + p1.GetId());

            p1.Name = "Keyboard";
            Console.WriteLine("p1.name = " + p1.Name);

            p1.Price = 30;
            Console.WriteLine("p1.price = " + p1.Price);

            p1.Quantity = 50;
            Console.WriteLine("p1.quantity = " + p1.Quantity);



            Product p2 = new Product(101, "Laptop", 1200);

            Product p3 = new();
            Product p4 = new(102, "Mobile", 2000);

            var p5 = new Product();
            //var p6 = new();



            Product p7 = new Product();
            p7.SetId(200);
            p7.Name = "Table";
            p7.Price = 60;
            p7.Quantity = 40;


            Product p8 = new Product()
            {
                Name = "Tablet",
                Price = 500,
                Quantity = 10
            };

            Console.WriteLine("\n\n\n");




            Account myAcc = new Account(500);
            //myAcc.Balance = 20000;
            Console.WriteLine("\nBalance = " + myAcc.Balance.ToString("C"));

            myAcc.Deposit(300);
            Console.WriteLine("\nBalance = " + myAcc.Balance.ToString("C"));

            try
            {
                myAcc.Withdraw(4000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nBalance = " + myAcc.Balance.ToString("C"));
        }
    }
}
