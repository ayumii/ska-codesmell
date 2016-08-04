using System;
using System.IO;

namespace GeneralizationCs
{
	public class LoginCommand
	{
        private LoginDetail _loginDetail = new LoginDetail();
        public LoginCommand(LoginDetail loginDetail)
        {
            _loginDetail = loginDetail;
        }
        private int Size
        {
            get
            {
                return Constants.Header.Length + Constants.SizeLength + Constants.CmdByteLength + 
                    Constants.Footer.Length +_loginDetail.LoginDetailString.Length;
            }
        }

        public void Write(TextWriter writer) {
			writer.Write(Constants.Header);
			writer.Write(Size);
			writer.Write(Constants.CommandChar0X01);
            writer.Write(_loginDetail.LoginDetailString);
			writer.Write(Constants.Footer);
		}
	}
}
