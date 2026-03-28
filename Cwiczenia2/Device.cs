namespace Cwiczenia2;

public class Device
{
    private static int _counter = 0;

    public int Id { get; }
    public string Name { get; set; }
    public AvailabilityStatus Availability { get; set; }

    public Device(string name, AvailabilityStatus availability)
    {
        Name = name;
        Availability = availability;
        Id = _counter++;
    }

}