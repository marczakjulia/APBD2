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
        throw new NotImplementedException();
    }
}