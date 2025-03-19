namespace APBD2;
public class SmartWatches: Device, IPowerNotifier
{
    private int _battery;
    public int Battery
    {
        get => _battery;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException();
            _battery = value;
            if (_battery < 20)
            {
                LowPower();
            }
            ;
        }
    }
    public SmartWatches(int id, string name, int battery) : base(id, name)
    {
        _battery = battery;
    }

    public void LowPower()
    {
    Console.WriteLine("Low Power, you need to charge your battery");
    }

    public override void TurnOn()
    {
        if (_battery < 11)
            throw new EmptyBatteryException("Battery is too low");
        base.TurnOn();
        _battery -= 10;
    }
}

public class EmptyBatteryException : Exception
{
    public EmptyBatteryException(string message) : base(message) { }
}