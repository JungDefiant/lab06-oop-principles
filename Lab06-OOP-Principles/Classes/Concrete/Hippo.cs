using Lab06_OOP_Principles.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Concrete
{
    public class Hippo : Pachyderm
    {
        public override bool IsDomestic { get => false; set => throw new NotImplementedException(); }
        public override bool CanBeRidden { get => false; set => throw new NotImplementedException(); }
        public override int NumberOfHorns { get => 0; set => throw new NotImplementedException(); }
        public override bool CanSwim { get => true; set => throw new NotImplementedException(); }
        public override bool HasTrunk { get => false; set => throw new NotImplementedException(); }
        public override string Name { get => "Hippo"; set => throw new NotImplementedException(); }
        public override string Diet { get => "herbivore"; set => throw new NotImplementedException(); }
        public override decimal AverageAdultWeight { get => 1500.0m; set => throw new NotImplementedException(); }

        public override string MakeSound()
        {
            return "Hippo noises";
        }

        public override string Move()
        {
            return "Waddle waddle";
        }
    }
}
