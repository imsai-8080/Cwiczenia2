namespace Cwiczenia2;
public class Program(){
    public static void Main(string[] args)
    {
        Console.WriteLine("Adding users...");
        User user1 = new User("Jan", "Nowak", UserType.Employee);
        User user2 = new User("Janina", "Kowalska", UserType.Employee);
        User user3 = new User("Jan", "Kowalski", UserType.Employee);
        User user4 = new User("Jan", "Kowalski Jr.", UserType.Student);
        User user5 = new User("John", "Smith", UserType.Student);
        User user6 = new User("Jane", "Lee", UserType.Student);
        User user7 = new User("Adam", "Adams", UserType.Student);
        Console.WriteLine("Adding devices...");
        Device device1 = new Camera("Canon 1b", AvailabilityStatus.Available, 6.8, 0.4);
        Device device2 = new Camera("Kodak Pro", AvailabilityStatus.Unavailable, 12.4, 0.5);
        Device device3 = new Laptop("Asus ROG", AvailabilityStatus.Available, 16, "Intel i5-14400k");
        Device device4 = new Laptop("HP Mini", AvailabilityStatus.Available, 8, "Intel i3-8700");
        Device device5 = new Projector("HP Projector Plus", AvailabilityStatus.Unavailable, 100, 50);
        Device device6 = new Projector("Lenovo Projector", AvailabilityStatus.Available, 10, 50);
        Device device7 = new Projector("LG CineBeam", AvailabilityStatus.Available, 200, 80);
        Device.ShowListOfDevices();
        DateTime date1 = new DateTime(2026, 3, 12);
        DateTime date2 = new DateTime(2026, 3, 15);
        DateTime date3 = new DateTime(2026, 3, 17);
        DateTime date4 = new DateTime(2026, 3, 22);
        Console.WriteLine("EXAMPLE: Successful rentals:");
        RentalService.RentADevice(date1, date2, date3, user5, device1);
        RentalService.RentADevice(date1, date2, date4, user5, device3);
        Console.WriteLine("EXAMPLE: Trying to rent an unavailable device:");
        RentalService.RentADevice(date1, date2, date4, user5, device2);
        Console.WriteLine("EXAMPLE: Trying to rent over the limit:");
        RentalService.RentADevice(date1, date2, date4, user5, device4);
        Console.WriteLine("EXAMPLE: Overdue rental: ");
        RentalService.RentADevice(date1, date3, date2, user4, device6);
        Report.GenerateReport();
    }
    
}