using MX_Target_Domain.Enums;
using MX_Target_Domain.Validation;

namespace MX_Target_Domain.ValueObjects
{
    public sealed class Document
    {
        public Document(string number, EDocumentType type)
        {
            ValidateDomain(number, type);
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        private void ValidateDomain(string number, EDocumentType type)
        {
            DomainExceptionValidation
                .When(
                    type == EDocumentType.CNPJ &&
                    number.Length != 14,
                    "CNPJ is invalid. Please type a valid CNPJ.");

            DomainExceptionValidation.When(
                    type == EDocumentType.CPF &&
                    number.Length != 11,
                    "CPF is invalid. Please type a valid CPF");

            DomainExceptionValidation.When(
                    type == EDocumentType.RG &&
                    number.Length != 9,
                    "RG is invalid. Please type a valid RG");

            SetValues(number, type);
        }

        private void SetValues(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }
    }
}
