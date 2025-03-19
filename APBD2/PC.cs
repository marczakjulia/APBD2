namespace APBD2;

public class PC: Device
{
    private string _OS;
    public PC(int id, string name, string OS) : base(id, name)
    {
        _OS = OS;
    }
    public override void TurnOn()
    {
        if(string.IsNullOrEmpty(_OS))
            throw new EmptySystemException("No OS provided");
        base.TurnOn();
    }
}
public class EmptySystemException : Exception
{
    public EmptySystemException(string message) : base(message) { }
}
