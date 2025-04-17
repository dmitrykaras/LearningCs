using System;
using System.Text;

namespace func1
{
    class functions
    {
        //проверка на то, что строка заканчивается на пункцтацию 
        static public bool EndsWithPunctuation(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            char LastChar = '\0'; //начинаем с пустого символа

            foreach (char ch in input)
            {
                LastChar = ch; //последний символ в строке 
            }
            return char.IsPunctuation(LastChar);
        }

        static public string ReversString(string input)
        {
            StringBuilder reversed = new StringBuilder(input.Length); //StringBuilder - меняет содержимое строки без создания нового объекта

            foreach (char ch in input)
            {
                reversed.Insert(0, ch); //переворачивает строчку
            }

            return reversed.ToString();
        }
    }

}
