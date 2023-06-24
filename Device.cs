public class Device
{
    public static DateTime Now { get { return DateTime.Now; } }
    public string Name { get; set; }

    public Device(string name)
    {
        Name = name;
    }

    public virtual void TurnOn()
    {
        Console.WriteLine($"Устройство '{Name}': Включено в {Device.Now}.");
    }

    public virtual void TurnOff()
    {
        Console.WriteLine($"Устройство '{Name}': Выключено в {Device.Now}.");
    }
}
