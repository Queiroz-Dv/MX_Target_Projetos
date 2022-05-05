using MX_Target_Projetos.ValueObjects;

namespace MX_Target_Projetos.Entities
{
    public class Person
    {
        public Person(Name name, int age, Document document)
        {
            Name = name;
            Age = age;
            Document = document;
        }

        public Name Name { get; private set; }
        public int Age { get; private set; }
        public Document Document { get; private set; }
    }
}
