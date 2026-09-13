using System;
using System.Diagnostics.Metrics;
using DeliveryApp.Models;


Courier courier1 = new()
{
    Name = "Олександр Коваленко"
};

Courier courier2 = new()
{
    Name = "Марiя Бондаренко"
};

// Створення об'єктів класу Parcel (Посилки)
Parcel parcel1 = new()
{
    Number = "NP20260001",
    Weight = 2.5,
    Recipient = "Iван Петренко"
};

Parcel parcel2 = new()
{
    Number = "NP20260002",
    Weight = 0.8,
    Recipient = "Олена Сидоренко"
};

Console.WriteLine("=== Служба доставки: Облiк посилок та кур'єрiв ===\n");

Console.WriteLine("Кур'єри:");
Console.WriteLine($"1. {courier1.Name}");
Console.WriteLine($"2. {courier2.Name}");

Console.WriteLine("\nПосилки:");
Console.WriteLine($"1. № {parcel1.Number} | Вага: {parcel1.Weight} кг | Отримувач: {parcel1.Recipient}");
Console.WriteLine($"2. № {parcel2.Number} | Вага: {parcel2.Weight} кг | Отримувач: {parcel2.Recipient}");

namespace DeliveryApp.Models
{
    public class Courier
    {
        public string Name { get; set; } = string.Empty;
    }

    public class Parcel
    {
        public string Number { get; set; } = string.Empty;
        public double Weight { get; set; }
        public string Recipient { get; set; } = string.Empty;
    }
}