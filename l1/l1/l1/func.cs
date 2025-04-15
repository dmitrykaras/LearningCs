using System;

namespace l1
{
    class functions
    {

        //(1+|x|)/(1+x)^1/3
        public static void simplefunction()
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double result = (1 + Math.Abs(x)) / Math.Pow(1 + x, 1.0 / 3.0);
            Console.WriteLine($"Результат: {result}\n");
        }

        //+1 если число положительное, иначе вывести его же
        public static void conditionfunction()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
                num ++;
            Console.WriteLine($"Резульат: {num}\n");
        }

        //A и B, найти сумму диапозона от числа A до B выключитльно
        public static void loopfunction()
        {
            Console.Write("Введите А: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите B(B>A): ");
            int B = int.Parse(Console.ReadLine());

            if (B <= A)
            {
                Console.WriteLine("Ошибка. B должен быть больше А\n");
                return;
            }

            int sum = 0;
            for (int i = A; i <= B; i++)
                sum += i;

            Console.WriteLine($"Резульат: {sum}\n");

        }
    }
}   

