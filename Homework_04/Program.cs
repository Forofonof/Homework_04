using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string name = "Вячеслав";
        string surname = "Форофонов";
        string temporary;
        Console.WriteLine($"Ваше Имя и Фамилия: {surname} {name}");
        temporary = name;
        name = surname;
        surname = temporary;
        Console.WriteLine($"Ваше Имя и Фамилия: {surname} {name}");
    }
}