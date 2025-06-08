using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main()
    {
        List<Triangle> triangles = new List<Triangle>(); //список для хранения всех треугольников
        Console.Write("Введите количество треугольников: ");
        int count = ReadInt();

        //ввод координат треугольников
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите координаты треугольника #{i + 1}");
            triangles.Add(ReadTriangle());
        }

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Показать все треугольники");
            Console.WriteLine("2. Выполнить перемещение треугольников");
            Console.WriteLine("3. Выход");
            Console.Write("Выберите пункт: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ShowTriangles(triangles); //вывод всех треугольников
                    break;

                case "2":
                    //ввод смещения по осям
                    Console.Write("Введите смещение по X: ");
                    double dx = ReadDouble();

                    Console.Write("Введите смещение по Y: ");
                    double dy = ReadDouble();

                    //перемещение каждого треугольника через foreach
                    foreach (var triangle in triangles)
                        triangle.Move(dx, dy);

                    Console.WriteLine("Треугольники успешно перемещены.");
                    break;

                case "3":
                    exit = true; //завершение программы
                    break;

                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    break;
            }
        }
    }

    static Triangle ReadTriangle() //ввод трёх точек для создания одного треугольника
    {
        Console.WriteLine("Точка A:");
        Point a = ReadPoint();
        Console.WriteLine("Точка B:");
        Point b = ReadPoint();
        Console.WriteLine("Точка C:");
        Point c = ReadPoint();

        return new Triangle(a, b, c);
    }

    static Point ReadPoint() //ввод координат одной точки
    {
        double x, y;
        Console.Write("X = ");
        x = ReadDouble();
        Console.Write("Y = ");
        y = ReadDouble();
        return new Point(x, y);
    }

    static void ShowTriangles(List<Triangle> triangles) //выводит список всех треугольников
    {
        if (triangles.Count == 0)
        {
            Console.WriteLine("Список треугольников пуст.");
            return;
        }

        for (int i = 0; i < triangles.Count; i++)
        {
            Console.WriteLine($"Треугольник #{i + 1}: {triangles[i]}");
        }
    }

    static int ReadInt() //безопасный ввод положительного целого числа.
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                return value;
            Console.Write("Ошибка. Введите положительное целое число: ");
        }
    }

    static double ReadDouble() //безопасный ввод дробного числа (с поддержкой запятой и точки)
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                return value;
            Console.Write("Ошибка. Введите корректное число: ");
        }
    }
}
