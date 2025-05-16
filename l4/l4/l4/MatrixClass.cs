using System;

public class Matrix
{
    private int[,] data = new int[4, 4];

    public Matrix() //конструктор по умолчанию с нулями
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                data[i, j] = 0;
    }

    public Matrix(int[,] values) //конструктор с параметрами 
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                data[i, j] = values[i, j];
    }

    public Matrix(Matrix other) //конструтор копирования
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                data[i, j] = other.data[i, j];
    }

    ~Matrix() //деструктор
    {
        Console.WriteLine("Деструктор вызван");
    }

    public void SetElement(int row, int col, int value) //метод установки значения элемента
    {
        data[row, col] = value;
    }

    public double GetElement(int row, int col) //метод получения значения элемента
    {
        return data[row, col];
    }

    public void MultiplyByScalar(int scalar) //метод умножения матрицы на число
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                data[i, j] *= scalar;
    }

    public Matrix Transpose() //метод транспонирование
    {
        Matrix result = new Matrix();
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                result.data[i, j] = data[j, i];
        return result;
    }

    public static Matrix operator +(Matrix a, Matrix b) //перегрузка оператора +
    {
        Matrix result = new Matrix();
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                result.data[i, j] = a.data[i, j] + b.data[i, j];
        return result;
    }

    public static Matrix operator -(Matrix a, Matrix b) //перегрузка оператора -
    {
        Matrix result = new Matrix();
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                result.data[i, j] = a.data[i, j] - b.data[i, j];
        return result;
    }

    public static Matrix ReadMatrix() //ввод массива с консоли
    {
        int[,] values = new int[4, 4];
        Console.WriteLine("Введите матрицу 4x4 (по 4 числа в строке через пробел):");

        for (int i = 0; i < 4; i++) //ввод построчно, а не через enter
        {
            Console.Write($"Строка {i + 1}: ");
            string? line = Console.ReadLine();
            if (line == null) continue;

            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 4)
            {
                Console.WriteLine("Ошибка: введите ровно 4 числа.");
                i--; // повтор строки
                continue;
            }

            for (int j = 0; j < 4; j++)
                values[i, j] = int.Parse(parts[j]);
        }

        return new Matrix(values);
    }

    public void Print() //метод для вывода матрицы
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write($"{data[i, j],8} ");
            Console.WriteLine();
        }
    }

}