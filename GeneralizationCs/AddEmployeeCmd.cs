using System;
using System.IO;

namespace GeneralizationCs
{

	public class AddEmployeeCmd
	{
        private EmployeeDetail _employeeDetail = new EmployeeDetail();
       
		public AddEmployeeCmd(EmployeeDetail employeeDetail)
		{
		    _employeeDetail = employeeDetail;
		}

        private int Size
        {
            get
            {
                return Constants.Header.Length + Constants.SizeLength + Constants.CmdByteLength + 
                    Constants.Footer.Length +_employeeDetail.EmployeeDetailString.Length;
            }
        }

        public void Write(TextWriter writer) {
			writer.Write(Constants.Header);
			writer.Write(Size);
			writer.Write(Constants.CommandChar0X02);
            writer.Write(_employeeDetail.EmployeeDetailString);
			writer.Write(Constants.Footer); 
		}
	}
}
