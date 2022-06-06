using MX_Target_Domain.Validation;
using MX_Target_Domain.ValueObjects;

namespace MX_Target_Domain.Entities
{
    public sealed class Person : Entity
    {
        public Person(int id, Name name, Age age, Document document, double? height, double weight, Gender gender)
        {
            Age = age;
            DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            Id = id;
            ValidateDomain(name, document, height, weight, gender);
        }

        public Person(Name name, Age age, Document document, double? height, double weight, Gender gender)
        {
            Age = age;
            ValidateDomain(name, document, height, weight, gender);
        }

        public Name Name { get; private set; }
        public Age Age { get; private set; }
        public Document Document { get; private set; }
        public double? Height { get; private set; }
        public double Weight { get; private set; }
        public Gender Gender { get; private set; }

        private void ValidateDomain(Name name, Document document, double? height, double weight, Gender gender)
        {
            DomainExceptionValidation
                .When(
                name == null,
                "Name is invalid. Please type again.");

            DomainExceptionValidation
               .When(
                document == null,
               "Document is invalid. Please type again.");

            DomainExceptionValidation
              .When(
               height == null,
              "Height is invalid. Please type again.");

            DomainExceptionValidation
             .When(
              height < 0,
             "Height is invalid. Please type again.");

            DomainExceptionValidation
              .When(
               weight < 0,
              "Weight is invalid. Please type again.");

            DomainExceptionValidation
             .When(
              gender == null,
             "Gender is invalid. Please type again.");

            SetValues(name, document, height, weight, gender);
        }

        private void SetValues(Name name, Document document, double? height, double weight, Gender gender)
        {
            Name = name;
            Document = document;
            Height = height;
            Weight = weight;
            Gender = gender;
        }

    }
}
