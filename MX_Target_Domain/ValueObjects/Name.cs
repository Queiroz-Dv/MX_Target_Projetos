using MX_Target_Domain.Validation;
using System;

namespace MX_Target_Domain.ValueObjects
{
    public sealed class Name
    {
        public Name(string firstName, string lastName)
        {
            ValidateDomain(firstName, lastName);
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private void ValidateDomain(string firstName, string lastName)
        {
            DomainExceptionValidation
                .When(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName),
                "Invalid firstname or lastname. Firstname and Lastname is required.");

            DomainExceptionValidation
                .When(firstName.Length < 3 || lastName.Length < 3,
                "Invalid firstname or lastname, too short, minimum 3 characters.");

            SetValues(firstName, lastName);
        }

        private void SetValues(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
