using System;

namespace GeneralizationCs
{
    public class EmployeeDetail
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string YearlySalary { get; set; }

        public string EmployeeDetailString { get; set; }

        public EmployeeDetail()
        {
            
        }
        public EmployeeDetail(string name, string address, string city, string state, string yearlySalary)
        {
            Name = name;
            Address = address;
            City = city;
            State = state;
            YearlySalary = yearlySalary;
            EmployeeDetailString = Name + Constants.Hex0X00 +
                                   Address + Constants.Hex0X00 +
                                   City + Constants.Hex0X00 +
                                   State + Constants.Hex0X00 +
                                   YearlySalary + Constants.Hex0X00;
        }

    }
}
