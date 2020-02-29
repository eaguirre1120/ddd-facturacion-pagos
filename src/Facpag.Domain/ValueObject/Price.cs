using System;

namespace Facpag.Domain.Entities
{
    public class Price
    {
        public double Amount { get; private set; }

        protected Price()
        {

        }

        public Price(double value)
        {

        }

        private void ValueNonNegative(double value)
        {
            if (value < 0)
            {
                throw new Exception("El precio no debe ser negativo.");
            }
        }

        private void ValueNonNull(double value)
        {
            if (value.Equals(null))
            {
                throw new Exception("El precio no debe ser nulo");
            }
        }
    }
}
