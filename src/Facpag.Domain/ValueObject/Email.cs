using System;

namespace Facpag.Domain.ValueObject
{
    public class Email
    {
        public string Address { get; private set; }

        protected Email()
        {

        }

        public Email(string address)
        {
            AddressValid(address);
            Address = address;
        }

        private void AddressValid(string address)
        {
            System.Text.RegularExpressions.Regex emailRegex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Match emailMatch = emailRegex.Match(address);
            if (!emailMatch.Success)
            {
                throw new Exception("La dirección de email es inválida");
            }
        }
    }
}
