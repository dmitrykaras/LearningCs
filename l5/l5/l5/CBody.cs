using System;
public abstract class CBody
{
    protected double size;

    public CBody()
    { //конструктор по умолчанию
        size = 0;
    }

    public CBody(double s)
    { //конструктор с параметрами
        size = s;
    }

    public CBody(CBody other)
    { //конструктор копирования 
        size = other.size;
    }

    public abstract void GetInfo(); //метод GetInfo
    public abstract string DisplayType(); //метод типа

    ~CBody()
    { //деструктор
        Console.WriteLine("CBody деструктор вызван");
    }

};