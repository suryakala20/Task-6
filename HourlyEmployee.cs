using properties;
class HourlyEmployee : Person
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public double TotalPay
    {
        get { return HoursWorked * PayPerHour; }
    }
    public HourlyEmployee(string fn, string ln, string email, DateTime dob,
                          double hours, double rate)
        : base(fn, ln, email, dob) //note: Variable names do not matter here. Only the order and type of parameters must match the parent constructor. 
    {
        HoursWorked = hours;
        PayPerHour = rate;
    }
}
