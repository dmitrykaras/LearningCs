using System;
public class CCube : CBody
{
    private double side;

    public CCube() : base() //конструтор по умолчаню
    {
        side = 0;
    }

    public CCube(double s) : base() //конструтор с параметрами
    {
        side = s;
    }

    public CCube(CCube other) : base() //конструтор копирования
    {
        side = other.side;
    }

    public override void GetInfo() //метод GetInfo
    {
        Console.WriteLine($"Куб: сторона = {side}, объём = {Math.Pow(side, 3)}\n");
    }

    public override string DisplayType() //метод типа
    {
        return "Куб\n";
    }

    ~CCube() //деструктор
    {
        Console.WriteLine("CCube деструктор вызван");
    }
}