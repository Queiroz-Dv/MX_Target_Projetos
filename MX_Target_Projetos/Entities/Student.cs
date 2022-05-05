using MX_Target_Projetos.ValueObjects;

namespace MX_Target_Projetos.Entities
{
    public class Student : Person
    {
        public Student(Name name, int age, Document document, SchoolDocument schoolDocument)
            : base(name, age, document)
        {
            SchoolDocument = schoolDocument;
        }

        public SchoolDocument SchoolDocument { get; private set; }
    }
}
