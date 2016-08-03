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
        public EmployeeDetail(string name, string address, string city, string state, string yearlysalary)
        {
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.YearlySalary = yearlysalary;
            this.EmployeeDetailString = this.Name + (char) 0x00 +
                                        this.Address + (char) 0x00 +
                                        this.City + (char) 0x00 +
                                        this.State + (char) 0x00 +
                                        this.YearlySalary + (char) 0x00;
        }

    }
}
