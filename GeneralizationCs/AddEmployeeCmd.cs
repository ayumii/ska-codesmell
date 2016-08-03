using System.IO;

namespace GeneralizationCs
{

	public class AddEmployeeCmd
	{
		private static char[] _Header = {(char)0xde, (char)0xad};
		private static char[] _CommandChar = {(char)0x02};
		private static char[] _Footer = {(char)0xbe, (char)0xef};
		private const int SIZE_LENGTH = 1;
		private const int CMD_BYTE_LENGTH = 1;

	    private EmployeeDetail _EmployeeDetail = new EmployeeDetail();
       
		public AddEmployeeCmd(EmployeeDetail employeeDetail)
		{
		    _EmployeeDetail = employeeDetail;
		}

        private int Size
        {
            get
            {
                return _Header.Length + SIZE_LENGTH + CMD_BYTE_LENGTH + _Footer.Length +
                       _EmployeeDetail.EmployeeDetailString.Length;
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
