using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создание списка имен
        List<string> names = new List<string>()
        {
            "Коля",
            "Петя",
            "Вера",
            "Надежда",
            "Любовь",
            "Сергей"
        };

        // Сортировка списка имен по алфавиту
        names.Sort();

        // Запрос имени для поиска
        Console.WriteLine("Введите имя для поиска:");
        string searchName = Console.ReadLine();

        // Использование метода BinarySearch для поиска имени в списке
        int index = names.BinarySearch(searchName);

        // Проверка результатов поиска
        if (index >= 0)
        {
            Console.WriteLine("Имя найдено!");
            Console.WriteLine(names[index]);
        }
        else
        {
            Console.WriteLine("Имя не найдено!");
            Console.WriteLine("0");
        }
    }
}