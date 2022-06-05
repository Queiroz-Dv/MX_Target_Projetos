using MX_Target_Domain.Validation;

namespace MX_Target_Domain.ValueObjects
{
    public sealed class Gender
    {
        public Gender(bool female, bool male)
        {
            ValidateDomain(female, male);
        }

        public bool Female { get; private set; }
        public bool Male { get; private set; }

        private void ValidateDomain(bool female, bool male)
        {
            DomainExceptionValidation.When(female == false || male == false, "Invalid gender type. " +
                "Gender is required");

            SetValues(female, male);
        }

        private void SetValues(bool female, bool male)
        {
            Female = female;
            Male = male;
        }
    }
}
