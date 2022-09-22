public class Vector 
{
    private double x;
    private double y;
    private double z;
    public Vector(double _x, double _y, double _z)
    {
        x = _x;
        y = _y;
        z = _z;
    }
    private double Getlength()
    {
        return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
    }
    public static bool operator<(Vector a, Vector b)
    {
        return a.Getlength() < b.Getlength();
    }
    public static bool operator>(Vector a, Vector b)
    {
        return a.Getlength() > b.Getlength();
    }
    public static Vector operator+(Vector a, Vector b)
    {
        Vector c = new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        return c;
    }
    public static double operator*(Vector a, Vector b)
    {
        return a.x*b.x + a.y*b.y + a.z*b.z;
    }
    public static Vector operator*(Vector a, double b)
    {
        Vector c = new Vector(a.x*b, a.y*b, a.z*b);
        return c;
    }
    public static Vector operator*(double a, Vector b)
    {
        return b * a;
    }
    public void Print()
    {
        Console.WriteLine("Vector with coorfinates x = {0}, y = {1}, z = {2}", x, y, z);
    }
}