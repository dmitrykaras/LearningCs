using System;

public class Matrix {
	private double[, ] data = new double[4, 4];

    public Matrix(); //по умолчанию
    public Matrix(double[, ] values); //с параметрами
    public Matrix(Matrix other); //копирования
    ~Matrix(); //деструктор

    public void SetElement(int row, int col, double value);
    public double GetElement(int row, int col);

    public void MultiplyByScalar(double scalar);
    public Matrix Transpose();

    public static Matrix operator +(Matrix a, Matrix b);
    public static Matrix operator -(Matrix a, Matrix b);
    public static Matrix ReadMatrix();
    public void Print();
}