using System;
using System.IO;

namespace GeneralizationCs
{
    public class LoginCommand : BaseCommand
    {
        private readonly LoginDetail _loginDetail;
        public LoginCommand(LoginDetail loginDetail)
        {
            _loginDetail = loginDetail;
        }

        protected override string RetrieveDetailString()
        {
            return _loginDetail.LoginDetailString;
        }

        protected override char RetrieveCommandChar()
        {
            return Constants.CommandChar0X01;
        }
    }
}
