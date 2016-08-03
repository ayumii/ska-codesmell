using System.IO;

namespace GeneralizationCs
{
	public class LoginCommand
	{
		private static char[] _Header = {(char)0xde, (char)0xad};
		private static char[] _CommandChar = {(char)0x01};
		private static char[] _Footer = {(char)0xbe, (char)0xef};
		private const int SIZE_LENGTH = 1;
		private const int CMD_BYTE_LENGTH = 1;

        private LoginDetail _LoginDetail = new LoginDetail();
        public LoginCommand(LoginDetail loginDetail)
        {
            _LoginDetail = loginDetail;
        }
        private int Size
        {
            get
            {
                return _Header.Length + SIZE_LENGTH + CMD_BYTE_LENGTH + _Footer.Length +
                _LoginDetail.LoginDetailString.Length;
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
