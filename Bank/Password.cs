using System;

namespace Bank
{
    public class Password
    {
        private string password;

        public Password()
        {
        }

        public Password(string password)
        {
            this.password = password;


        }

        public double GetLength()
        {
           return password.Length;
        }
    }
}