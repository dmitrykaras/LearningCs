using System;

public class Point //класс для храненияя координат
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y) 
    {
        X = x;
        Y = y;
    }

    public void Move(double dx, double dy) //смещает точку на заданные значения по осям X и Y.
    {
        X += dx;
        Y += dy;
    }

    public override string ToString() //вывод X, Y
    {
        return $"({X}, {Y})";
    }
}

public class Triangle //класс для A, B, C
{
    public Point A { get; set; }
    public Point B { get; set; }
    public Point C { get; set; }

    public Triangle(Point a, Point b, Point c) 
    {
        A = a;
        B = b;
        C = c;
    }

    public void Move(double dx, double dy) //смещает все точки треугольника на заданные значения по X и Y
    {
        A.Move(dx, dy);
        B.Move(dx, dy);
        C.Move(dx, dy);
    }

    public override string ToString() //возвращает строковое представление треугольника
    {
        return $"A{A}, B{B}, C{C}";
    }
}
