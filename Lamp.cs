public class Lamp : Device
{
    public bool Light { get; set; }

    public Lamp(string name) : base(name)
    {
        Light = false;
    }

    public override void TurnOn()
    {
        Console.WriteLine($"Лампа '{Name}': Включена в {Device.Now}.");
        Light = true;
    }

    public override void TurnOff()
    {
        Console.WriteLine($"Лампа '{Name}': Выключена в {Device.Now}.");
        Light = false;
    }
}