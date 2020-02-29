using System;

namespace Facpag.Domain.ValueObject
{
    public class Stock
    {
        public int Quantity { get; private set; }

        //Constructor to EntityFramework
        protected Stock()
        {
        }

        public Stock(int quantity)
        {
            ValueNonNegative(quantity);
            Quantity = quantity;
        }

        private void ValueNonNegative(int value)
        {
            if (value < 0)
            {
                throw new Exception("La cantidad no debe ser negativo.");
            }
        }

        private void ValueNonNull(int value)
        {
            if (value.Equals(null))
            {
                throw new Exception("La cantidad no debe ser nulo");
            }
        }
    }
}
