namespace Cwiczenia2;

public class Projector : Device
{
    public int Brightness { get; set; }
    public int Contrast { get; set; }

    public Projector(string name, AvailabilityStatus availability, int brightness, int contrast) : base(name,
        availability)
    {
        Brightness = brightness;
        Contrast = contrast;
    }
}