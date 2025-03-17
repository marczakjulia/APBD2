namespace APBD2
{
    public abstract class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTurnedOn { get; private set; }

        public Device(int id, string name)
        {
            Id = id;
            Name = name;
            IsTurnedOn = false;
        }

        public virtual void TurnOn()
        {
            IsTurnedOn = true;
            Console.WriteLine($"{Name} is now ON.");
        }

        public void TurnOff()
        {
            IsTurnedOn = false;
            Console.WriteLine($"{Name} is now OFF.");
        }

        public override string ToString()
        {
            return $"Device [ID: {Id}, Name: {Name}, IsTurnedOn: {IsTurnedOn}]";
        }
    }
}