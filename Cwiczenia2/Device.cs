namespace Cwiczenia2;

public class Device
{
    private static int _counter = 0;
    private static List<Device> _listOfDevices = new List<Device>();

    public int Id { get; }
    public string Name { get; set; }
    public AvailabilityStatus Availability { get; set; }

    public Device(string name, AvailabilityStatus availability)
    {
        Name = name;
        Availability = availability;
        Id = _counter++;
        _listOfDevices.Add(this);
    }

    public static void ShowListOfDevices()
    {
        Console.WriteLine("List of devices:");
        foreach (var device in _listOfDevices)
        {
            Console.Write(device.Name);
            switch (device.GetType().ToString())
            {
                case "Cwiczenia2.Camera": Console.Write(" (Camera)"); break;
                case "Cwiczenia2.Laptop": Console.Write(" (Laptop)"); break;
                case "Cwiczenia2.Projector":  Console.Write(" (Projector)"); break;
                default: Console.WriteLine(" (Unknown device) "); break;
            } 
            if (device.Availability == AvailabilityStatus.Available)
            {
                Console.WriteLine(": Available");
            }
            else
            {
                Console.WriteLine(": Not Available");
            }

        }
    }
    
    public static void ShowAvailableDevices()
    {
        Console.WriteLine("Available Devices:");
        foreach (var device in _listOfDevices)
        {
            if (device.Availability == AvailabilityStatus.Available)
            {
                Console.WriteLine(device.Name);
            }
        }
    }

    public static List<Device> GetListOfDevices()
    {
        return _listOfDevices;
    }
    
}