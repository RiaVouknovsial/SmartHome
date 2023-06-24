public class MotionSensor : Device
{
    public bool IsMotionDetected { get; set; }
    public event MotionDetectedDelegate MotionDetectedEvent;
    public event NotifyDelegate Notify;

    public MotionSensor(string name) : base(name)
    {
        IsMotionDetected = false;
    }

    public void DetectMotion()
    {
        if (IsMotionDetected)
        {
            MotionDetectedEvent?.Invoke(this, EventArgs.Empty);
            Notify?.Invoke($"Датчик движения '{Name}': Обнаружено движение в {Device.Now}.");
            Notify?.Invoke($"Датчик движения '{Name}': Сработала звуковая сирена в {Device.Now}.");
        }
        else
        {
            Notify?.Invoke($"Датчик движения '{Name}': Все спокойно в {Device.Now}.");
        }
    }

    public override void TurnOn()
    {
        Console.WriteLine($"Датчик движения '{Name}': Включен в {Device.Now}.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"Датчик движения '{Name}': Выключен в {Device.Now}.");
        IsMotionDetected = false;
    }
}
