/// <summary>
/// Легковые автомобили
/// </summary>
public class PassengerСar : Car
{
    protected char CarClass { get; private set; }
    protected string LetterСlassification { get; private set;}
    public PassengerСar(char carClass, string letterСlassification, string stamp, string body, int yearOfRelease, string transmission, string color, string engine, string manufacturer, int weight, int price, float speed) : base(stamp, body, yearOfRelease, transmission, color, engine, manufacturer, weight, price, speed)
    {
        this.CarClass = carClass;
        this.LetterСlassification = letterСlassification;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            $"Класс: {CarClass}\n" +
            $"Буквенная классификация: {LetterСlassification}\n"
            );
        Console.ResetColor();
    }


}
