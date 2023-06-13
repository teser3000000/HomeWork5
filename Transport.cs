
public abstract class Transport
{
    public string Engine { get; private set; }
    public string Manufacturer { get; private set; }
    public int Weight { get; private set; }
    public int Price { get; private set; }
    public float Speed { get; private set; }
    public Transport(string engine, string manufacturer, int weight, int price, float speed)
    {
        this.Engine = engine;
        this.Manufacturer = manufacturer;
        this.Weight = weight;
        this.Price = price;
        this.Speed = speed;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine(
            $"Производитель: {Manufacturer}\n" +
            $"Вес: {Weight} тонн\n" +
            $"Цена: {Price} млн\n" +
            $"Скорость: {Speed} км/ч"
            );
    }
}
