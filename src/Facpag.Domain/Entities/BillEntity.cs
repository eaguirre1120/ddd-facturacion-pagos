using Facpag.Domain.ValueObject;

namespace Facpag.Domain.Entities
{
    public class BillEntity : BaseEntity
    {
        public string Client { get; set; }
        public string Telephone { get; set; }
        public Email Email { get; set; }
        public string PaymentType { get; set; }

        protected BillEntity()
        {

        }

        public BillEntity(string client, string telephone, Email email, string paymentType)
        {
            Client = client;
            Telephone = telephone;
            Email = email;
            PaymentType = paymentType;
        }
        public void SetClient(string client)
        {
            Client = client;
        }
        public void SetTelephone(string telephone)
        {
            Telephone = telephone;
        }
        public void SetEmail(Email email)
        {
            Email = email;
        }
        public void SetPaymentType(string paymentType)
        {
            PaymentType = paymentType;
        }

    }
}
