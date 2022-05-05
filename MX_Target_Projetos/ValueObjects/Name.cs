using System;

namespace MX_Target_Projetos.ValueObjects
{
    public class Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (FirstName.Length < 3)
                Console.WriteLine("Nome deve conter pelo menos 3 caracteres");
            
            if (LastName.Length > 40)
                Console.WriteLine("Nome deve conter pelo menos 40 caracteres");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
