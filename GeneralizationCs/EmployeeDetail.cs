
using System.Collections.Specialized;

namespace GeneralizationCs
{
    public class EmployeeDetail
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int YearlySalary { get; set; }

        public EmployeeDetail(string name, string address, string city, string state, int yearlysalary)
        {
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.YearlySalary = yearlysalary;
        }

    }
}
