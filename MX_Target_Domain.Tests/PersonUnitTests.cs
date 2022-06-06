using MX_Target_Domain.ValueObjects;
using System;
using Xunit;

namespace MX_Target_Domain.Tests
{
    public class PersonUnitTests
    {
        private readonly Name _name = new Name("Naylane", "Andrade");
        private readonly Document _document = new Document("99999999999", Enums.EDocumentType.CPF);
        private readonly Gender _gender = new Gender('F');
        //private readonly Age

        [Fact]
        public void CreatePerson_WithValidParameters_ResultObjectValidState()
        {

            
        }
    }
}

