using System;
using l1;

class main
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите функцию:\n 1. Вычисления по уравнению\n 2. Функция состояния \n 3. Цекцлическая функция\n 0. Выход");
            Console.Write("Ваш выбор: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    functions.simplefunction();
                    break;
                case 2:
                    functions.conditionfunction();
                    break;
                case 3:
                    functions.loopfunction();
                    break;
                case 0:
                    Console.WriteLine("Выход из программы");
                    return;
                default:
                    Console.WriteLine("Неправиьный выбор\n");
                    break;
                

            }
        }
    }

}