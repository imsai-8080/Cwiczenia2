namespace Cwiczenia2;

public static class RentalService
{
    private static int _studentRentalLimit = 2;
    private static int _employeeRentalLimit = 5;

    public static void RentADevice(
        DateTime dateOfRental,
        DateTime exceptedDateOfReturn,
        DateTime actualDateOfReturn,
        User rentalUser,
        Device rentalDevice) 
    {
        if (rentalDevice.Availability == AvailabilityStatus.Unavailable)
        {
            Console.WriteLine("The device is unavailable right now.");
            return;
        }

        List<Rental> listOfRentals = Rental.GetListOfRentals();
        int numberOfActiveRentals = 0;
        foreach (Rental rental in listOfRentals)
        {
            if (rental.RentalUser == rentalUser)
            {
                numberOfActiveRentals++;
            }
        }

        if (rentalUser.UserType == UserType.Employee && numberOfActiveRentals > _employeeRentalLimit)
        {
            Console.WriteLine("Employee " + rentalUser.FirstName + " " + rentalUser.LastName + " exceeded the limit.");
            return;
        }

        if (rentalUser.UserType == UserType.Student && numberOfActiveRentals < _studentRentalLimit)
        {
            Console.WriteLine("Student " + rentalUser.FirstName + " " + rentalUser.LastName + " exceeded the limit.");
            return;
        }
        Rental newRental = new Rental(dateOfRental, exceptedDateOfReturn, actualDateOfReturn,  rentalUser, rentalDevice);
        Console.WriteLine("Rental of " + rentalDevice.Name + " was added to the system.");
        if (newRental.IsOverdue)
        {
            Console.WriteLine("The rental is overdue.");
            Console.WriteLine("Overdue fine: " + newRental.OverdueFine);
        }
    }
}