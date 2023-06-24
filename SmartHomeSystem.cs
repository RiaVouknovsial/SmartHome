public class SmartHomeSystem
{
    public event NotifyDelegate Notify;

    public void RegisterMotionSensor(MotionSensor motionSensor)
    {
        motionSensor.MotionDetectedEvent += HandleMotionDetected;
    }

    public void HandleMotionDetected(object sender, EventArgs e)
    {
        MotionSensor detectedMotionSensor = (MotionSensor)sender;
        Notify?.Invoke($"Движение обнаружено в датчике '{detectedMotionSensor.Name}' в {Device.Now}.");
        Notify?.Invoke("Включение света и запись видео.");
    }
}
