using System.Reflection;

public class Train : Transport
{
    public int TrainNumber { get; private set; }
    public string FollowingDistance { get; private set; }
    public Train(int trainNumber, string followingDistance, string engine, string manufacturer, int weight, int price, float speed) : base(engine, manufacturer, weight, price, speed)
    {
        this.TrainNumber = trainNumber;
        this.FollowingDistance = followingDistance;
    }
    public override void ShowInfo()
    {
        Console.WriteLine("Информация о поезде:\n" +
        "\n" +
            $"Номер поезда : {TrainNumber}\n" +
            $"Дальность : {FollowingDistance}"
            );
        base.ShowInfo();
    }


}
