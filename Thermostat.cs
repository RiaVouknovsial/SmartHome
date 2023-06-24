public class Thermostat : Device
{
    public double Temperature { get; set; }

    public Thermostat(string name) : base(name)
    {
        Temperature = 0;
    }

    public void SetTemperature(double temperature)
    {
        Temperature = temperature;
        Console.WriteLine($"Термостат '{Name}': Температура установлена на {Temperature}°C в {Device.Now}.");
    }

    public override void TurnOn()
    {
        Console.WriteLine($"Термостат '{Name}': Включен в {Device.Now}.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"Термостат '{Name}': Выключен в {Device.Now}.");
    }
}
