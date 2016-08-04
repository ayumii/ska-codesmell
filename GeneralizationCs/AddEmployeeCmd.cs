using System;
using System.IO;

namespace GeneralizationCs
{

	public class AddEmployeeCmd
	{
        private static char[] _Header = {(char)Constants.CHAR_0xde, (char)Constants.CHAR_0xad};
        private static char[] _CommandChar = { (char)Constants.CHAR_0x02};
        private static char[] _Footer = {(char)Constants.CHAR_0xbe, (char)Constants.CHAR_0xef};

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
			writer.Write(_CommandChar);
            writer.Write(_EmployeeDetail.EmployeeDetailString);
			writer.Write(_Footer); 
		}
	}
}
