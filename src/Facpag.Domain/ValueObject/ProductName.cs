using System;

namespace Facpag.Domain.ValueObject
{
    public class ProductName
    {
        public const int NameMaxLength = 254;
        public string Value { get; private set; }

        protected ProductName()
        {

        }

        public ProductName(string name)
        {
            NameNonNullOrEmpty(name);
            NameExceedMaxLength(name);
            Value = name;
        }

        private void NameNonNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("El nombre del producto no puede estar vacio o nulo");
            }
        }

        private void NameExceedMaxLength(string value)
        {
            if (value.Length > ProductName.NameMaxLength)
            {
                throw new Exception("La longitud del nombre del producto no puede ser mayor al permitido: " + ProductName.NameMaxLength);
            }
        }
    }
}
