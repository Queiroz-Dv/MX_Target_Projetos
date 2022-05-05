using MX_Target_Projetos.Enums;

namespace MX_Target_Projetos.ValueObjects
{
    public class SchoolDocument
    {
        public SchoolDocument(string number, ESchoolDocumentType eSchoolDocument)
        {
            Number = number;
            ESchoolDocument = eSchoolDocument;
            Validate();
        }

        public string Number { get; private set; }
        public ESchoolDocumentType ESchoolDocument { get; private set; }

        private bool Validate()
        {
            if (ESchoolDocument == ESchoolDocumentType.Particular && Number.Length == 14)
                return true;

            if (ESchoolDocument == ESchoolDocumentType.Publico && Number.Length == 11)
                return true;

            return false;
        }
    }
}
