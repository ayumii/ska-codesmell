﻿namespace GeneralizationCs
{
    public class LoginDetail
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string LoginDetailString { get; set; }

        public LoginDetail()
        {

        }

        public LoginDetail(string name, string password)
        {
            this.Name = name;
            this.Password = password;
            this.LoginDetailString = this.Name + (char)Constants.HEX_0x00 +
                                        this.Password + (char)Constants.HEX_0x00;
        }

    }
}
