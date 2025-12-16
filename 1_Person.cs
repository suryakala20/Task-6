using System;
namespace properties
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private DateTime dateOfBirth;
        public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.dateOfBirth = dateOfBirth;
        }
        public bool IsAdult
        {
            get
            {
                int age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now < dateOfBirth.AddYears(age))
                    age--;

                return age >= 18;
            }
        }
        public bool IsBirthDay
        {
            get
            {
                return DateTime.Now.Day == dateOfBirth.Day &&
                       DateTime.Now.Month == dateOfBirth.Month;
            }
        }
        public string SunSign
        {
            get
            {
                int day = dateOfBirth.Day;
                int month = dateOfBirth.Month;
                if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) return "Aries";
                if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) return "Taurus";
                if ((month == 5 && day >= 21) || (month == 6 && day <= 20)) return "Gemini";
                if ((month == 6 && day >= 21) || (month == 7 && day <= 22)) return "Cancer";
                if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) return "Leo";
                if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) return "Virgo";
                if ((month == 9 && day >= 23) || (month == 10 && day <= 22)) return "Libra";
                if ((month == 10 && day >= 23) || (month == 11 && day <= 21)) return "Scorpio";
                if ((month == 11 && day >= 22) || (month == 12 && day <= 21)) return "Sagittarius";
                if ((month == 12 && day >= 22) || (month == 1 && day <= 19)) return "Capricorn";
                if ((month == 1 && day >= 20) || (month == 2 && day <= 18)) return "Aquarius";
                return "Pisces";
            }
        }
        public string ScreenName
        {
            get
            {
                return firstName.ToLower().Substring(0, 2) +
                       lastName.ToLower().Substring(0, 2) +
                       dateOfBirth.ToString("ddMMyy");
            }
        }
    }
}

