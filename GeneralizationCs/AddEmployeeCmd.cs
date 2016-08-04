using System;
using System.IO;

namespace GeneralizationCs
{

	public class AddEmployeeCmd
	{
        private static char[] _Header = {(char)Constants.Hex0Xde, (char)Constants.Hex0Xad};
        private static char[] _CommandHex = {(char)Constants.Hex0X02};
        private static char[] _Footer = {(char)Constants.Hex0Xbe, (char)Constants.Hex0Xef};

        private EmployeeDetail _EmployeeDetail = new EmployeeDetail();
       
		public AddEmployeeCmd(EmployeeDetail employeeDetail)
		{
		    _EmployeeDetail = employeeDetail;
		}

        private int Size
        {
            get
            {
                return _Header.Length + (int)Constants.SizeLength + (int)Constants.CmdByteLength + 
                    _Footer.Length +_EmployeeDetail.EmployeeDetailString.Length;
            }
        }

        public void Write(TextWriter writer) {
			writer.Write(_Header);
			writer.Write(Size);
			writer.Write(_CommandHex);
            writer.Write(_EmployeeDetail.EmployeeDetailString);
			writer.Write(_Footer); 
		}
	}
}
