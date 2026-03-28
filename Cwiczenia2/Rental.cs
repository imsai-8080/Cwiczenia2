namespace Cwiczenia2;

public class Rental
{
    private static int _overdueFineRate = 5;
    
    public DateTime DateOfRental { get; set; }
    public DateTime ExceptedDateOfReturn { get; set; }
    public DateTime ActualDateOfReturn { get; set; }
    public int ?OverdueFine { get; set; }
    public User RentalUser { get; set; }
    public Device RentedDevice { get; set; }
    public bool IsOverdue { get; set; }

    public Rental(
        DateTime dateOfRental,
        DateTime exceptedDateOfReturn,
        DateTime actualDateOfReturn,
        User rentalUser,
        Device rentalDevice)
    {
        DateOfRental = dateOfRental;
        ExceptedDateOfReturn = exceptedDateOfReturn;
        ActualDateOfReturn = actualDateOfReturn;
        RentalUser = rentalUser;
        RentedDevice = rentalDevice;
        IsOverdue = ExceptedDateOfReturn > ActualDateOfReturn;
        if (IsOverdue)
        {
            TimeSpan daysOverdue = ExceptedDateOfReturn - ActualDateOfReturn;
            OverdueFine = _overdueFineRate * daysOverdue.Days;
        }
    }
}