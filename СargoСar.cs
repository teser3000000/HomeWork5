/// <summary>
/// Грузовые автомобили
/// </summary>
internal class СargoСar : Car
{
    public int NumberOfAs { get; private set; }
    public int MaxLoadCapacity { get; private set;}
    public СargoСar(int numberOfAs, int maxLoadCapacity, string stamp, string body, int yearOfRelease, string transmission, string color, string engine, string manufacturer, int weight, int price, float speed) : base(stamp, body, yearOfRelease, transmission, color, engine, manufacturer, weight, price, speed)
    {
        this.NumberOfAs = numberOfAs;
        this.MaxLoadCapacity = maxLoadCapacity;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            $"Количество осей: {NumberOfAs}\n" +
            $"Максимальная грузоподъемость: {MaxLoadCapacity} кг\n"
            );
        Console.ResetColor();
    }

}

