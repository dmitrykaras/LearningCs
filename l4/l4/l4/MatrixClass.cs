using System;

public class Matrix
{
    private double[,] data = new double[4, 4];

    public Matrix() //конструктор по умолчанию с нулями
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                data[i, j] = 0.0;
    }

    public Matrix(double[,] values) //конструктор с параметрами 
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

    public void SetElement(int row, int col, double value) //метод установки значения элемента
    {
        data[row, col] = value;
    }

    public double GetElement(int row, int col) //метод получения значения элемента
    {
        return data[row, col];
    }

    public void MultiplyByScalar(double scalar) //метод умножения матрицы на число
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

    public static Matrix ReadMatrix() //
    {
        double[,] values = new double[4, 4];
        Console.WriteLine("Введите элементы матрицы 4x4:");
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                values[i, j] = Convert.ToDouble(Console.ReadLine());
        return new Matrix(values);
    }

    public void Print() //метод для вывода матрицы
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write($"{data[i, j],8:F2} ");
            Console.WriteLine();
        }
    }

}