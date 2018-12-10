using System;

namespace MurTestTask.models
{
    public class UserData
    {
        private String email;
        private String password;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public UserData WithEmail(string email)
        {
            this.Email = email;
            return this;
        }

        public UserData WithPassword(string password)
        {
            this.Password = password;
            return this;
        }

        override
        public string ToString()
        {
            return "UserData{" +
                "email='" + email + '\'' +
                "password='" + password + '\'' +
                '}';
        }
    }
}
