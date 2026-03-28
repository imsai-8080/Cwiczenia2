namespace Cwiczenia2;

public static class Report
{
    public static void GenerateReport()
    {
        Console.WriteLine("Generating report...");
        List<Device> listOfDevices = Device.GetListOfDevices();
        List<User> listOfUsers = User.GetUserList();
        List<Rental>  listOfRentals = Rental.GetListOfRentals();
        int numberOfDevices = listOfDevices.Count;
        int numberOfUsers = listOfUsers.Count;
        int numberOfRentals = listOfRentals.Count;
        Console.WriteLine($"Number of devices: {numberOfDevices}");
        Console.WriteLine($"Number of users: {numberOfUsers}");
        Console.WriteLine($"Number of rentals: {numberOfRentals}");
    }
}