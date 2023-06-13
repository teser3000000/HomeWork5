public class Airplane : Transport
{
    protected string Model { get; private set; }
    protected int NumberOfSeats { get; private set; }
    protected int FlightRange { get; private set; }
    protected int MaximumFlightAltitude { get; private set; }

    public Airplane(string model, int numberOfSeats, int flightRange, int maximumFlightAltitude, string engine, string manufacturer, int weight, int price, float speed) : base(engine, manufacturer, weight, price, speed)
    {
        this.Model = model;
        this.NumberOfSeats = numberOfSeats;
        this.FlightRange = flightRange;
        this.MaximumFlightAltitude = maximumFlightAltitude;
    }
    public override void ShowInfo()
    {
        Console.WriteLine("Информация о самолете:\n" +
            "\n" +
            $"Модель: {Model}\n" +
            $"Кол-во пассажирских мест: {NumberOfSeats}\n" +
            $"Дальность полета: {FlightRange} тысячи километров\n" +
            $"Максимальная высота полета: {MaximumFlightAltitude} тысяч метров" 
            );
        base.ShowInfo();
    }


}

