namespace MX_Target_Domain.ValueObjects
{
    public sealed class Gender
    {
        public Gender(char genderType)
        {
            ValidateValueObject(genderType);
        }

        private void ValidateValueObject(char genderType)
        {
            GetGenderType(genderType);
            SetGender(genderType);
        }

        public char GenderType { get; private set; }

        private string GetGenderType(char genderType)
        {
            if (genderType == 'M')
                return "Male";
            
            if (genderType == 'F')
                return "Female";
            
            return "Other/non binary";
        }

        private void SetGender(char genderType)
        {

            GenderType = genderType;
        }
    }
}
