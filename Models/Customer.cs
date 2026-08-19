using System.Diagnostics.Contracts;

namespace VideoRentalStore.Models;

public class Customer
{
    public int Id { get; private set; }
    public string Name { get; set; } //required?
    public DateOnly BirthDate { get; private set; }
    Dictionary<string, string> contact = new Dictionary<string, string>();
    List<Rental> rentals = new List<Rental>();

    public Customer(int id, string name, DateOnly birthDate, Dictionary<string, string> contact)
    {
        Id = id;
        Name = name;
        BirthDate = birthDate;
        this.contact = contact;
    }

    public override string ToString()
    {
        string customerData = $"Customer #{Id}\nName: {Name}\nBirth Date: {BirthDate}\n";

        customerData += "Contact\n";
        foreach(var entry in contact)
        {
            customerData += $"{entry.Key}: {entry.Value}\n";
        }

        /*
        customerDate += "Rentals:\n";
        foreach(var entry in rentals)
        {
            customerData += $"Rentals:\n";
        }*/

        return customerData;
    }
}
