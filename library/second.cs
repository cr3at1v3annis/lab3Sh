public class Car : IEquatable<Car>
{
    private string Name;
    private string Engine;
    private int MaxSpeed;
    public Car(string _n, string _e, int _s) 
    {
        Name = _n;
        Engine = _e;
        MaxSpeed = _s;
    }
    public string GetName() => Name;
    public string GetEngine() => Engine;
    public int GetSpeed() => MaxSpeed;
    public override string ToString()
    {
        return Name.ToString();
    }
    public override bool Equals(object? obj)
    {
        return this == obj as Car;
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Engine.GetHashCode() ^ MaxSpeed.GetHashCode();
    }
    public virtual bool Equals(Car? other) => this == other;
    public static bool operator ==(Car? left, Car? right) => left?.Name == right?.Name && left?.Engine == right?.Engine && left?.MaxSpeed == right?.MaxSpeed;
    public static bool operator !=(Car? left, Car? right) => !(left == right);
}

public class CarCatalog
{
    private Car[] cars;
    public CarCatalog(params Car[] _cars) => cars = _cars.ToArray();
    public string this[int index] => $"Name is {cars[index].GetName()} and engine is {cars[index].GetEngine()}";
}