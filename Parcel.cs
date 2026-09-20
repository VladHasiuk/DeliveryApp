namespace DeliveryApp.Models;

public class Parcel
{
    private string _number = string.Empty;
    private double _weight;
    private string _recipient = string.Empty;

    public string Number
    {
        get => _number;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Номер посилки не може бути порожнім.");
            }
            _number = value.Trim();
        }
    }
    public double Weight
    {
        get => _weight;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Вага посилки повинна бути більшою за нуль.");
            }
            _weight = value;
        }
    }

    public string Recipient
    {
        get => _recipient;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Ім'я отримувача не може бути порожнім.");
            }
            _recipient = value.Trim();
        }
    }

    public ParcelStatus Status { get; private set; }

    public Parcel(string number, double weight, string recipient)
    {
        Number = number;
        Weight = weight;
        Recipient = recipient;
        Status = ParcelStatus.Created;
    }

    public void ChangeStatus(ParcelStatus newStatus)
    {
   
        if (Status == ParcelStatus.Delivered)
        {
            Console.WriteLine($"[Помилка] Посилку №{Number} вже доставлено! Зміна стану неможлива.");
            return;
        }
        Console.WriteLine($"[Статус] Посилка №{Number}: {Status} ---> {newStatus}");
        Status = newStatus;
    }
}