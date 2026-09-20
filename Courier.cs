namespace DeliveryApp.Models;

public class Courier
{
    private string _name = string.Empty;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Ім'я кур'єра не може бути порожнім.");
            }
            _name = value.Trim();
        }
    }
    public Courier(string name)
    {
        Name = name;
    }
}