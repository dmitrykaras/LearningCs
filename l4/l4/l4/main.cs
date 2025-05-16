using System;

class main
{
    static void Main()
    {
        Matrix m1 = new Matrix(); // по умолчанию
        Matrix m2 = new Matrix(new int[,] {
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12},
            {13,14,15,16}
        });

        Matrix m3 = new Matrix(m2); // копирование
        Matrix m4 = null; // через указатель

        while (true)
        {
            Console.WriteLine("Меню: ");
            Console.WriteLine("1. Создание и вывод состояния объекта авторского класса");
            Console.WriteLine("2. Изменение значения члена-данного");
            Console.WriteLine("3. Применение уникального метода класса");
            Console.WriteLine("4. Применение арифметических и операторов отношений к объектам класса");
            Console.WriteLine("5. Ввод матрицы 4х4");
            Console.WriteLine("0. Выход");
            Console.Write("Ваш выбор: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: //вызов Print
                    Console.WriteLine("Матрица 1:");
                    m1.Print();
                    Console.WriteLine("Матрица 2:");
                    m2.Print();
                    break;

                case 2: //изменение элемента по i и j
                    Console.Write("Введите i(0-3): ");
                    int i = int.Parse(Console.ReadLine());
                    Console.Write("Введите j(0-3): ");
                    int j = int.Parse(Console.ReadLine());
                    Console.Write("Введите значение: ");
                    int v = int.Parse(Console.ReadLine());
                    if (i < 0 || i > 3 || j < 0 || j > 3)
                    {
                        Console.WriteLine("Индексы должны быть от 0 до 3.");
                        break;
                    }
                    m1.SetElement(i, j, v);
                    Console.WriteLine("Матрица после изменения:");
                    m1.Print();
                    break;

                case 3: //транспонирование матрицы
                    m2 = m2.Transpose();
                    m2.Print();
                    break;
                  
                case 4: //арифметические действия
                    Console.WriteLine("Выберите действие: 1. Умножение; 2. Разность матриц; 3. Сложение матриц");
                    Console.Write("Ваш выбор: ");
                    int choiceObj = int.Parse(Console.ReadLine());
                    switch (choiceObj)
                    {
                        case 1:
                            Console.Write("Введите число: ");
                            int s = int.Parse(Console.ReadLine());
                            m2.MultiplyByScalar(s);
                            m2.Print();
                            break;
                        case 2:
                            Matrix diff = m1 - m2;
                            Console.WriteLine("Разность:");
                            diff.Print();
                            break;
                        case 3:
                            Matrix sum = m1 + m2;
                            Console.WriteLine("Сумма:");
                            sum.Print();
                            break;
                        case 0:
                            Console.WriteLine("Отмена выбора\n");
                            break;
                        default:
                            Console.WriteLine("Неправиьный выбор\n");
                            break;
                    }
                    break;

                case 5:
                    m4 = Matrix.ReadMatrix();
                    m4.Print();
                    break;
                case 0:
                    Console.WriteLine("Выход из программы");
                    return;
                default:
                    Console.WriteLine("Неправильный выбор\n");
                    break;
            }
        }
    }
}