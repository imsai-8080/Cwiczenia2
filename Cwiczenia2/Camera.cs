namespace Cwiczenia2;

public class Camera : Device
{
    public double Resolution { get; set; }
    public double Fov { get; set; }

    public Camera(string name, AvailabilityStatus availability, double resolution, double fov) : base(name,
        availability)
    {
        Resolution = resolution;
        Fov = fov;
    }
}