class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(
            "Hari", "Doe", "hari@gmail.com",
            new DateTime(1980, 5, 25), 50000);
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Is Adult: " + emp.IsAdult);
        Console.WriteLine("Sun Sign: " + emp.SunSign);
        Console.WriteLine("Is Birthday Today: " + emp.IsBirthDay);
        Console.WriteLine("Screen Name: " + emp.ScreenName);
        Console.WriteLine();
        HourlyEmployee hourly = new HourlyEmployee(
            "John", "Smith", "john@gmail.com",
            new DateTime(1995, 8, 15), 40, 500);
        Console.WriteLine("Hourly Employee Total Pay: " + hourly.TotalPay);
        PermanentEmployee permanent = new PermanentEmployee(
            "Sara", "Lee", "sara@gmail.com",
            new DateTime(1990, 3, 10), 30000, 20000, 5000);
        Console.WriteLine("Permanent Employee Total Pay: " + permanent.TotalPay);
        Console.WriteLine("Permanent Employee Net Pay: " + permanent.NetPay);
    }
}
