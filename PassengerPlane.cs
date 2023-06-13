/// <summary>
/// Пассажирские самолеты
/// </summary>
public class PassengerPlane : Airplane
{
    public string Category { get; private set; }
    public PassengerPlane(string category, string model, int numberOfSeats, int flightRange, int maximumFlightAltitude, string engine, string manufacturer, int weight, int price, float speed) : base(model, numberOfSeats, flightRange, maximumFlightAltitude, engine, manufacturer, weight, price, speed)
    {
        this.Category = category;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Категория: {Category}\n");
        Console.ResetColor();
    }

}

