using Lab06_OOP_Principles.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Concrete
{
    public class Rhino : Pachyderm
    {
        public override bool IsDomestic { get => false; set => throw new NotImplementedException(); }
        public override bool CanBeRidden { get => false; set => throw new NotImplementedException(); }
        public override int NumberOfHorns { get => 2; set => throw new NotImplementedException(); }
        public override bool CanSwim { get => true; set => throw new NotImplementedException(); }
        public override bool HasTrunk { get => false; set => throw new NotImplementedException(); }
        public override string Name { get => "Rhino"; set => throw new NotImplementedException(); }
        public override string Diet { get => "herbivore"; set => throw new NotImplementedException(); }
        public override decimal AverageAdultWeight { get => 1100.0m; set => throw new NotImplementedException(); }

        public override string MakeSound()
        {
            return "Moooo";
        }

        public override string Move()
        {
            return "Rumble but slower";
        }
    }
}
