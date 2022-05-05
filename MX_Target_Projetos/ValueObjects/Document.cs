using MX_Target_Projetos.Enums;

namespace MX_Target_Projetos.ValueObjects
{
    public class Document
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
            Validate();
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        private bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            if (Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }
    }
}
