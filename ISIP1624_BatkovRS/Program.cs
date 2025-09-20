// See https://aka.ms/new-console-template for more information
using System;
using System.IO;


const int min_operations = 2;
const int max_operations = 40;

Console.WriteLine("Введите количество операций от 2 до 40: ");
int n;
n = int.Parse(Console.ReadLine());
decimal total = 0;

while (n < min_operations || n > max_operations)
{
    Console.WriteLine("Введите число меньше 40 или больше 2");
    n = int.Parse(Console.ReadLine());

}

string[] names = new string[n];
decimal[] sums = new decimal[n];

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] parts = input.Split(";");

    if (parts.Length != 2)
    {
        Console.WriteLine("Неверный формат! Название услуги или товара; Количество денег");
        i--;
        continue;
    }

    string name = parts[0].Trim();
    string amountStr = parts[1].Trim();


    if (!decimal.TryParse(amountStr, out decimal amount) || amount < 0)
    {
        Console.WriteLine("Некорректная сумма. Введите число больше или равное 0.");
        i--; // повторим попытку
        continue;
    }

    total += amount;

    Console.WriteLine($"Добавлено: {name} - {amount} руб.");
}

    

bool exit = false;
while (!exit)
{
    Console.WriteLine("\nМеню:");
    Console.WriteLine("1. Вывод данных");
    Console.WriteLine("2. Статистика (среднее, максимальное, минимальное, сумма)");
    Console.WriteLine("3. Сортировка по цене (пузырьковая сортировка)");
    Console.WriteLine("4. Конвертация валюты");
    Console.WriteLine("5. Поиск по названию");
    Console.WriteLine("0. Выход");
    Console.Write("Выберите пункт: ");
}
    