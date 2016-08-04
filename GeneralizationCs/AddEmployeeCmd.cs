using System;
using System.IO;

namespace GeneralizationCs
{

	public class AddEmployeeCmd
	{
        private static char[] _Header = {(char)Constants.HEX_0xde, (char)Constants.HEX_0xad};
        private static char[] _CommandHEX = { (char)Constants.HEX_0x02};
        private static char[] _Footer = {(char)Constants.HEX_0xbe, (char)Constants.HEX_0xef};

        private EmployeeDetail _EmployeeDetail = new EmployeeDetail();
       
		public AddEmployeeCmd(EmployeeDetail employeeDetail)
		{
		    _EmployeeDetail = employeeDetail;
		}

        private int Size
        {
            get
            {
                return _Header.Length + (int)Constants.SIZE_LENGTH + (int)Constants.CMD_BYTE_LENGTH + 
                    _Footer.Length +_EmployeeDetail.EmployeeDetailString.Length;
            }
        }

        public void Write(TextWriter writer) {
			writer.Write(_Header);
			writer.Write(Size);
			writer.Write(_CommandHEX);
            writer.Write(_EmployeeDetail.EmployeeDetailString);
			writer.Write(_Footer); 
		}
	}
}
