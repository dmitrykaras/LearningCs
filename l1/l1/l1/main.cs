using System;
using l1;

class main
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите функцию:\n 1. SimpleFunction\n 2. ConditionFunction \n 3. LoopFunction \n 0. Выход");
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