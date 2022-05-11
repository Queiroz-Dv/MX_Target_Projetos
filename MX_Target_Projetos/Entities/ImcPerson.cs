﻿using System;
using MX_Target_Projetos.ValueObjects;

namespace MX_Target_Projetos.Entities
{
    public class ImcPerson
    {
        public ImcPerson(Name name, string birthdate, double? height, string gender)
        {
            Name = name;
            Gender = gender;
            Birthdate = birthdate;
            Height = height;
            ProcessIMC(Gender, Height);
        }

        private void ProcessIMC(string gender, double? height)
        {
            if (gender.StartsWith("M"))
            {
                GetIdealWeightToMale(height);
            }
            else if (gender.StartsWith("F"))
            {
                GetIdealWeightToFemale(height);
            }
            else
            {
                Console.WriteLine("Dados para gênero inválidos, tente novamente.");
                Console.ReadKey();
            }
        }

        public Name Name { get; private set; }
        public string Birthdate { get; private set; }
        public double? Height { get; private set; }
        public string Gender { get; private set; }

        double GetIdealWeightToMale(double? height, double weight = 72.7)
        {
            double idealWeight = Convert.ToDouble(weight * height) - 58;
            return idealWeight;
        }

        private double GetIdealWeightToFemale(double? height, double weight = 62.1)
        {
            double idealWeight = Convert.ToDouble(weight * height) - 44.7;
            return idealWeight;
        }

    }
}
