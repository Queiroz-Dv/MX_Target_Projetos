using MX_Target_Domain.Validation;
using System;

namespace MX_Target_Domain.ValueObjects
{
    public sealed class Age
    {
        public Age(DateTime getAge)
        {
            CalcAge(getAge);
            ValidateValueObject(getAge);
            SetValueObject(getAge);
        }

        public DateTime GetAge { get; private set; }
     
        private void ValidateValueObject(DateTime getAge)
        {
            DomainExceptionValidation
                .When(
                getAge.Year < 1900,
                "Invalid datetime.");
        }


        private void SetValueObject(DateTime getAge)
        {
            GetAge = getAge;
        }

        private int CalcAge(DateTime birthdate)
        {
            int age = DateTime.Today.Year - birthdate.Year;
            if (DateTime.Today.DayOfYear < birthdate.DayOfYear)
                age--;
           
            return age;
        }

    }
}
