using System;
using System.IO;

namespace GeneralizationCs
{
	public class LoginCommand
	{
        private static char[] _Header = {(char)Constants.HEX_0xde, (char)Constants.HEX_0xad};
        private static char[] _CommandHEX = {(char)Constants.HEX_0x01};
		private static char[] _Footer = {(char)Constants.HEX_0xbe, (char)Constants.HEX_0xef};

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
			writer.Write(_CommandHEX);
            writer.Write(_LoginDetail.LoginDetailString);
			writer.Write(_Footer);
		}
	}
}
