using System;

namespace SafeArrayExample
{
    public class CArray<T>
    {
        private T[] array;
        private int size;

        //конструктор по умолчанию (по умолчанию размер 5)
        public CArray()
        {
            size = 5;
            array = new T[size];
        }

        //конструктор с заданием размера
        public CArray(int size)
        {
            this.size = size;
            array = new T[size];
        }

        //индексатор с проверкой границ
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                    return array[index];
                else
                    throw new IndexOutOfRangeException("Индекс вне границ массива");
            }
            set
            {
                if (index >= 0 && index < size)
                    array[index] = value;
                else
                    throw new IndexOutOfRangeException("Индекс вне границ массива");
            }
        }

        //метод ввода (с использованием Convert.ChangeType)
        public void Input()
        {
            Console.WriteLine($"Введите {size} элементов типа {typeof(T).Name}:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"[{i}]: ");
                array[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
        }

        //метод вывода
        public void Output()
        {
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }

    //отдельная реализация для string с переопределением методов
    public class CArrayString : CArray<string>
    {
        public CArrayString(int size) : base(size) { }

        public new void Input()
        {
            Console.WriteLine("Введите строки:");
            for (int i = 0; i < 5; i++)
            {
                this[i] = Console.ReadLine();
            }
        }

        public new void Output()
        {
            Console.WriteLine("Вы ввели строки:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"[{i}] = {this[i]}");
            }
        }
    }

    //обёртка для массива с типом по умолчанию (int)
    public class CArrayDefault : CArray<int>
    {
        public CArrayDefault() : base() { }
    }
}
