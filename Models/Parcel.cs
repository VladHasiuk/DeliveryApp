namespace DeliveryApp.Models;

public class Parcel            
{
    
    public string Number { get; set; } = string.Empty;
    public double Weight { get; set; }
    public string Recipient { get; set; } = string.Empty;
}