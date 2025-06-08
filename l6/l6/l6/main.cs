using System;
using SafeArrayExample;

class Program
{
    static void Main()
    {
        //int
        CArray<int> intArray = new CArray<int>(3);
        intArray.Input();
        intArray.Output();

        //float
        CArray<float> floatArray = new CArray<float>(4);
        floatArray.Input();
        floatArray.Output();

        //string (специализация)
        CArrayString stringArray = new CArrayString(5);
        stringArray.Input();
        stringArray.Output();

        //по умолчанию (int, размер 5)
        CArrayDefault defaultArray = new CArrayDefault();
        defaultArray.Input();
        defaultArray.Output();

        //проверка индексации
        try
        {
            Console.WriteLine(defaultArray[10]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Исключение: " + ex.Message);
        }
    }
}
