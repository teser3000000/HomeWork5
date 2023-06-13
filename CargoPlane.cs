/// <summary>
/// Грузовые самолеты
/// </summary>
public class CargoPlane : Airplane
{
    public int MaximumLoadCapacity { get; private set; }
    public int CargoCompartment { get; private set; }
    public string CargoHatch { get; private set; }
    public CargoPlane(int maximumLoadCapacity, int cargoCompartment, string cargoHatch, string model, int numberOfSeats, int flightRange, int maximumFlightAltitude, string engine, string manufacturer, int weight, int price, float speed) : base(model, numberOfSeats, flightRange, maximumFlightAltitude,  engine, manufacturer, weight, price, speed)
    {
        this.MaximumLoadCapacity = maximumLoadCapacity;
        this.CargoCompartment = cargoCompartment;
        this.CargoHatch = cargoHatch;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            $"Максимальная грузоподъемность: {MaximumLoadCapacity} тонн\n" +
            $"Грузовых отсеков: {CargoCompartment}\n" +
            $"Грузовой люк: {CargoHatch}\n"
            );
        Console.ResetColor();
    }
}
