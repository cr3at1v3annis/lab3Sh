public class Currency 
{
    public float Value;
    public Currency(float _v) 
    {
        Value = _v;
    }
}
public class CurrencyUSD : Currency
{
    private float inchange = 80;
    public CurrencyUSD(float _v): base(_v) {}
    public static implicit operator CurrencyUSD(float x)
    {
        return new CurrencyUSD(x);
    }
    public static explicit operator float(CurrencyUSD cusd)
    {
        return cusd.Value;
    }
}
public class CurrencyRUB : Currency
{
    private float inchange = 90;
    public CurrencyRUB(float _v): base(_v) {}
    public static implicit operator CurrencyRUB(float x)
    {
        return new CurrencyRUB(x);
    }
    public static explicit operator float(CurrencyRUB crub)
    {
        return crub.Value;
    }
    
}
public class CurrencyEUR : Currency
{
    private float inchange = 100;
    public CurrencyEUR(float _v): base(_v) {}
    public static implicit operator CurrencyEUR(float x)
    {
        return new CurrencyEUR(x);
    }
    public static explicit operator float(CurrencyEUR ceur)
    {
        return ceur.Value;
    }
}