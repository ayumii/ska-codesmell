using System;
using System.IO;

namespace GeneralizationCs
{

    public class AddEmployeeCmd : BaseCommand
    {
        private readonly EmployeeDetail _employeeDetail;

        public AddEmployeeCmd(EmployeeDetail employeeDetail)
        {
            _employeeDetail = employeeDetail;
        }

        protected override string RetrieveDetailString()
        {
            return _employeeDetail.EmployeeDetailString;
        }
        protected override char RetrieveCommandChar()
        {
            return Constants.CommandChar0X02;
        }

    }
}
