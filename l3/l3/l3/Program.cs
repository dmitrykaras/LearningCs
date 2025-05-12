using System;
using System.IO;

//струтура данных
struct SALARY
{
    public string LastName;
    public string FirstName;
    public string Position;
    public decimal Salary;

    //присваивания значения
    public SALARY(string lastname, string firstname, string position, decimal salary)
    {
        LastName = lastname;
        FirstName = firstname;
        Position = position;
        Salary = salary;
    }

    //вывод строк
    public override string ToString()
    {
        return $"{LastName} {FirstName} {Position} {Salary}";
    }
}

class Program
{
    //функция сортировки
    static void Sort(ref SALARY[] arr)
    {
        Array.Sort(arr, CompareBySalary);
    }
    //реализация сортировки
    static int CompareBySalary(SALARY a, SALARY b)
    {
        return a.Salary.CompareTo(b.Salary);
    }

    //фильтрация
    static SALARY[] Filter(SALARY[] arr, decimal minSalary)
    {
        List<SALARY> result = new List<SALARY>(); //временный список для хранения подходящих записей

        foreach (SALARY s in arr) //перебирает каждый элемент
        {
            if (s.Salary >= minSalary)
            {
                result.Add(s); //добавление в список, если условие выполнено
            }
        }
        return result.ToArray();
    }

    static void Main()
    {
        string[] lines = File.ReadAllLines("data.txt"); //чтение строк из data.txt 
        SALARY[] staff = new SALARY[lines.Length]; //создание массива структур с длинной в кол-во строк


        for (int i = 0; i < lines.Length; i++) //проходимся по каждой строке файла
        {
            string[] parts = lines[i].Split(' '); //разбиваем на пробелы
            //создаём стр-у SALARY и сохраняем её в массив
            staff[i] = new SALARY(parts[0], parts[1], parts[2], decimal.Parse(parts[3])); //преобразуем строку в число с плавающей точкой
        } 

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Исходные данные");
            Console.WriteLine("2. Отсортированные данные");
            Console.WriteLine("3. Фильтрация по окладу(>= 50000)");
            Console.WriteLine("0. Выход");
            Console.Write("Ваш выбор:");

            int choice = int.Parse(Console.ReadLine());

            {
                switch (choice)
                {
                    case 1:
                        foreach (var s in staff) //перебираем каждый элемент массива
                            Console.WriteLine(s);
                        Console.WriteLine();
                        break;

                    case 2:
                        //вызов функции Sort 
                        Sort(ref staff); //ref staff передаёт массив staff по ссылке, а не по значению
                        File.WriteAllLines("data1.txt", staff.Select(s => s.ToString())); //преобразуем каждую структуру в строку и пишем резульат в data1.txt
                        Console.WriteLine("Сортировка выполнена. Результат в data1.txt");
                        Console.WriteLine();
                        break;

                    case 3:
                        SALARY[] filtered = Filter(staff, 50000); //вызов фильтрации и получаем новый массив
                        File.WriteAllLines("data2.txt", filtered.Select(s => s.ToString())); //преобразуем каждую структуру в строку и пишем резульат в data2.txt
                        Console.WriteLine("Фильтрация выполнена. Результат в data2.txt");
                        Console.WriteLine();
                        break;

                    case 0:
                        Console.WriteLine("Завершение работы программы");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}