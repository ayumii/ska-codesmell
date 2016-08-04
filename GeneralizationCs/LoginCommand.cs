using System;
using System.IO;

namespace GeneralizationCs
{
	public class LoginCommand
	{
        private static char[] _Header = {(char)Constants.CHAR_0xde, (char)Constants.CHAR_0xad};
        private static char[] _CommandChar = {(char)Constants.CHAR_0x01};
		private static char[] _Footer = {(char)Constants.CHAR_0xbe, (char)Constants.CHAR_0xef};

        private LoginDetail _LoginDetail = new LoginDetail();
        public LoginCommand(LoginDetail loginDetail)
        {
            _LoginDetail = loginDetail;
        }
        private int Size
        {
            get
            {
                return _Header.Length + (int)Constants.SIZE_LENGTH + (int)Constants.CMD_BYTE_LENGTH + 
                    _Footer.Length +_LoginDetail.LoginDetailString.Length;
            }
        }

        public void Write(TextWriter writer) {
			writer.Write(_Header);
			writer.Write(Size);
			writer.Write(_CommandChar);
            writer.Write(_LoginDetail.LoginDetailString);
			writer.Write(_Footer);
		}
	}
}
