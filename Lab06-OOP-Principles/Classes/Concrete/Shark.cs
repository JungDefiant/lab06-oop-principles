using Lab06_OOP_Principles.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Concrete
{
    public class Shark : Fish
    {
        public override int NumberOfFins { get => 5; set => throw new NotImplementedException(); }
        public override decimal SwimSpeed { get => 25.0m; set => throw new NotImplementedException(); }
        public override bool IsBottomFeeder { get => false; set => throw new NotImplementedException(); }
        public override string Name { get => "Shark"; set => throw new NotImplementedException(); }
        public override string Diet { get => "carnivore"; set => throw new NotImplementedException(); }
        public override decimal AverageAdultWeight { get => 500.0m; set => throw new NotImplementedException(); }

        public override string MakeSound()
        {
            return "Dun Dun Dun Dun DUN DUN";
        }

        public override string Move()
        {
            return "Swim swim";
        }
    }
}
