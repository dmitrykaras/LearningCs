using System;

public class CSphere : CBody
{
    private double radius;

    public CSphere() : base()
    {
        radius = 0;
    }

    public CSphere(double r) : base(r)
    {
        radius = r;
    }

    public CSphere(CSphere other) : base(other)
    {
        radius = other.radius;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"Шар: радиус = {radius}, объём = {(4.0 / 3) * Math.PI * Math.Pow(radius, 3):F2}\n");
    }

    public override string DisplayType() //метод типа
    {
        return "Шар";
    }

    ~CSphere()
    {
        Console.WriteLine("CSphere деструктор вызван");
    }
}