using properties;
class PermanentEmployee : Person
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }

    public double TotalPay
    {
        get { return HRA + DA; }
    }
    public double NetPay
    {
        get { return TotalPay - Tax; }
    }
    public PermanentEmployee(string fn, string ln, string email, DateTime dob,
                             double hra, double da, double tax)
        : base(fn, ln, email, dob)
    {
        HRA = hra;
        DA = da;
        Tax = tax;
    }
}
