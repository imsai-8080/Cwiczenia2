namespace Cwiczenia2;

public class Laptop : Device
{
    public int RAM { get; set; }
    public string CPU { get; set; }

    public Laptop(string name, AvailabilityStatus availability, int ram, string cpu) : base(name, availability)
    {
        RAM = ram;
        CPU = cpu;
    }
}