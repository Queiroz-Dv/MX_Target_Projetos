﻿using MX_Target_Projetos.Interfaces;
using MX_Target_Projetos.ValueObjects;

namespace MX_Target_Projetos.Entities
{
    public sealed class Person
    {
        public Person(Name name, int age, Document document, string phone = null)
        {
            Name = name;
            Age = age;
            Document = document;
        }

        public Name Name { get; private set; }
        public int Age { get; private set; }
        public Document Document { get; private set; }
        public double? Height { get; private set; }
        public string Gender { get; private set; }
    }
}
