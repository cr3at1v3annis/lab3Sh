namespace Program;
public class Program
{
    static void Main()
    {
        // task 1
        Vector a = new Vector(1, 2, 3);
        Vector b = new Vector(2, 4, 6);
        Vector c = a + b;
        c.Print();
        double d = a * b;
        Console.WriteLine("Multiplication of vector a and vector b is {0}", d);
        if (a < b) {
            Console.WriteLine("vector a is less than vector b");
        } else if (a > b) {
            Console.WriteLine("vector b is less than vector a");
        } else {
            Console.WriteLine("vector b is equal to vector a");
        }
        Vector e = a * d;
        e.Print();
        //task 2
        Car c1 = new Car("Honda", "EXZ", 200);
        Car c2 = new Car("Honda", "EXZ", 200);
        if (c1.Equals(c2))
        {
            Console.WriteLine("The same object using the generic Equals method");
        }
        if (c1 == c2) 
        {
            Console.WriteLine("The same car using the == operator");
        }
        Car c3 = new Car("Lada", "EXHJ-2022", 250);
        CarCatalog cc = new CarCatalog(c1, c2, c3); 
        Console.WriteLine($"cars[0] = {cc[0]}");
        Console.WriteLine($"cars[2] = {cc[2]}");
        // task 3
        CurrencyEUR ceur = new CurrencyEUR(60);
        CurrencyUSD cusd = new CurrencyUSD(70);
        CurrencyRUB crub = new CurrencyRUB(50);

        //float money = 1000;
        float x = (float)ceur;
        Console.WriteLine(x);   
        CurrencyEUR ceur2 = x;
        Console.WriteLine(ceur2.Value);  

    }
}
