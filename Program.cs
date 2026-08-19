using VideoRentalStore.Models;

Customer customer = new Customer(1, "ed", new DateOnly(2003, 12, 2), new Dictionary<string, string>
{
    ["email"] = "ed@email.com",
    ["phone"] = "999999999",
    ["adress"] = "R. XX, 9"
});

Console.WriteLine(customer);