using DeliveryApp.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=== ЛАБОРАТОРНА РОБОТА №2: ІНКАПСУЛЯЦІЯ ТА КЕРУВАННЯ СТАНОМ ===\n");


try
{
    Courier courier = new Courier("Олександр Коваленко");
    Parcel parcel = new Parcel("NP20260001", 2.5, "Іван Петренко");

    Console.WriteLine($"Кур'єр: {courier.Name}");
    Console.WriteLine($"Посилка №{parcel.Number} | Вага: {parcel.Weight} кг | Отримувач: {parcel.Recipient}");
    Console.WriteLine($"Початковий статус: {parcel.Status}\n");

 
    Console.WriteLine("--- Зміна станів посилки ---");
    parcel.ChangeStatus(ParcelStatus.Accepted);
    parcel.ChangeStatus(ParcelStatus.InTransit);
    parcel.ChangeStatus(ParcelStatus.Delivered);

   
    parcel.ChangeStatus(ParcelStatus.InTransit);
}
catch (Exception ex)
{
    Console.WriteLine($"Виникла помилка: {ex.Message}");
}

Console.WriteLine("\n--- Перевірка валідації (некоректні дані) ---");


try
{
    Console.WriteLine("Спроба створити посилку з вагою -1.5 кг:");
    Parcel invalidParcel = new Parcel("NP20260002", -1.5, "Олена Сидоренко");
}
catch (Exception ex)
{
    Console.WriteLine($"[Перехоплено виняток]: {ex.Message}");
}


try
{
    Console.WriteLine("\nСпроба створити кур'єра з порожнім ім'ям:");
    Courier invalidCourier = new Courier("   ");
}
catch (Exception ex)
{
    Console.WriteLine($"[Перехоплено виняток]: {ex.Message}");
}