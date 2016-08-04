namespace GeneralizationCs
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
            Name = name;
            Password = password;
            LoginDetailString = Name + Constants.Hex0X00 +
                                Password + Constants.Hex0X00;
        }

    }
}
