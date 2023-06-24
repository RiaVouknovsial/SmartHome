//Вам предстоит разработать систему управления умным домом, которая должна реагировать на различные события в доме
//и выполнять соответствующие действия. В доме есть различные устройства, такие как датчики движения, термостаты,
//светильники и т. д.

//Ваша задача состоит в следующем:

//Создайте классы для каждого типа устройства в доме. Например, классы MotionSensor, Thermostat, Light и т. д.
//Каждый класс должен иметь свои свойства и методы, относящиеся к данному типу устройства.

//Создайте событие с именем MotionDetectedEvent, которое будет генерироваться при обнаружении движения с
//помощью датчика движения. Событие должно предоставлять информацию о местоположении, времени и других деталях,
//связанных с обнаруженным движением.

//В классе SmartHomeSystem создайте метод RegisterMotionSensor, который будет принимать в качестве параметра
//объект типа MotionSensor и регистрировать его в системе.

//Создайте метод HandleMotionDetected, который будет вызываться при возникновении события event MotionDetectedEvent.
//Этот метод должен принимать параметр типа EventArgs или наследника от EventArgs и выполнять соответствующие действия,
//например, включать свет или записывать видео.

//В классе SmartHomeSystem создайте метод StartMonitoring, который будет запускать мониторинг движения.
//Этот метод должен включать все зарегистрированные датчики движения и обрабатывать событие MotionDetectedEvent,
//вызывая метод HandleMotionDetected.

//Реализуйте метод Main, в котором создайте объект класса SmartHomeSystem, зарегистрируйте несколько объектов
//MotionSensor с помощью метода RegisterMotionSensor и запустите мониторинг с помощью метода StartMonitoring.


using System;

MotionSensor motionSensor = new MotionSensor("MotionSensor1");
Thermostat thermostat = new Thermostat("Thermostat1");
Lamp lamp = new Lamp("Lamp1");

SmartHomeSystem smartHomeSystem = new SmartHomeSystem();
smartHomeSystem.RegisterMotionSensor(motionSensor);

motionSensor.Notify += DisplayMessage;

Console.WriteLine("------------------------------------------");

motionSensor.TurnOn();
thermostat.TurnOn();
lamp.TurnOn();

Console.WriteLine("------------------------------------------");

motionSensor.TurnOff();
thermostat.TurnOff();
lamp.TurnOff();

Console.WriteLine("------------------------------------------");

motionSensor.DetectMotion();
motionSensor.TurnOff();

Console.WriteLine("------------------------------------------");

thermostat.SetTemperature(25.5);

lamp.TurnOff();

Console.ReadLine();


static void DisplayMessage(string message)
{
    Console.WriteLine(message);
}

public delegate void NotifyDelegate(string message);
public delegate void MotionDetectedDelegate(object sender, EventArgs e);










