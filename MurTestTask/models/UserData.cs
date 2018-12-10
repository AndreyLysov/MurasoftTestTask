using System;

namespace MurTestTask.models
{
    public class UserData
    {
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        
        override
        public string ToString()
        {
            return "UserData{" +
                "email='" + Email + '\'' +
                "password='" + Password + '\'' +
                '}';
        }
    }
}
