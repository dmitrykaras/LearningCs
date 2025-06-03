using System;

class Program
{
    static void Main()
    {
        CBody body = null; //body указывает на null
        CCube cube = new CCube(3); //создание объекта куб
        CSphere sphere = new CSphere(2); //создание объекта шар

        while (true)
        {
            Console.WriteLine("Меню: ");
            Console.WriteLine("1. Просмотр состояния текущего объекта ");
            Console.WriteLine("2. Вызов метода GetInfo()");
            Console.WriteLine("3. Изменение ссылки на CBody ");
            Console.WriteLine("0. Выход ");
            Console.WriteLine("Ваш выбор: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (body != null)
                        Console.WriteLine($"Тип объекта: {body.DisplayType()}\n");
                    else
                        Console.WriteLine("Указатель не установлен\n");
                    break;

                case 2:
                    if (body != null)
                        body.GetInfo();
                    else
                        Console.WriteLine("Указатель body не инициализирован\n");
                    break;

                case 3:
                    Console.WriteLine("Выбор указателя: 1. Куб; 2. Шар; 3. Отмена выбора");
                    int choiceObj = int.Parse(Console.ReadLine());

                    switch (choiceObj)
                    {
                        case 1:
                            body = cube;
                            Console.WriteLine("Указатель указывает на Куб\n");
                            break;
                        case 2:
                            body = sphere;
                            Console.WriteLine("Указатель указывает на Шар\n");
                            break;
                        case 3:
                            Console.WriteLine("Отмена выбора\n");
                            break;
                        default:
                            Console.WriteLine("Неверный ввод\n");
                            break;
                    }
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