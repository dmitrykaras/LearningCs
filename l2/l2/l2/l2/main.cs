using System;
using System.Text;
using func1;

namespace func1
{
    class main
    {
        static void Main()
        {
            string tmp;

            while (true)
            {
                Console.Write("Введите строку: ");
                tmp = Console.ReadLine();

                //если строка не заканчивается на знак припинаения, то выход из программы
                if (!functions.EndsWithPunctuation(tmp))
                {
                    Console.WriteLine("Ошибка. Последний символ не пунктуация\n");
                    break;
                }

                //вывод строки
                string result = functions.ReversString(tmp);
                Console.WriteLine("Обратная строка" + result);
                Console.WriteLine();

            }
        }
    }
}
