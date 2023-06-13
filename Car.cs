public class Car : Transport
{
    protected string Stamp { get; private set; } //марка
    protected int YearOfRelease { get; private set; }
    protected string Transmission { get; private set; } // коробка передач
    protected string Color { get; private set; }
    protected string Body { get; private set; }
    public Car(string stamp, string body, int yearOfRelease, string transmission, string color, string engine, string manufacturer, int weight, int price, float speed) : base(engine, manufacturer, weight, price, speed)
    {
        this.Stamp = stamp;
        this.Body = body;
        this.YearOfRelease = yearOfRelease;
        this.Transmission = transmission;
        this.Color = color;
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"Информация об автомобиле {Stamp}:\n" +
            "\n" +
            $"Год выпуска: {YearOfRelease}\n" + 
            $"Коробка передач: {Transmission}\n" + 
            $"Кузов: {Body}\n" + 
            $"Цвет: {Color}"
            );
        base.ShowInfo();
    }
}

