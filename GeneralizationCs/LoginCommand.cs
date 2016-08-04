using System;
using System.IO;

namespace GeneralizationCs
{
	public class LoginCommand
	{
        private static char[] _Header = {(char)Constants.Hex0Xde, (char)Constants.Hex0Xad};
        private static char[] _CommandHEX = {(char)Constants.Hex0X01};
		private static char[] _Footer = {(char)Constants.Hex0Xbe, (char)Constants.Hex0Xef};

        private LoginDetail _LoginDetail = new LoginDetail();
        public LoginCommand(LoginDetail loginDetail)
        {
            _LoginDetail = loginDetail;
        }
        private int Size
        {
            get
            {
                return _Header.Length + (int)Constants.SizeLength + (int)Constants.CmdByteLength + 
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
