using Lab06_OOP_Principles.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Concrete
{
    public class Wolf : Canine
    {
        public override bool LivesInPack { get => true; set => throw new NotImplementedException(); }
        public override bool IsDomesticated { get => false; set => throw new NotImplementedException(); }
        public override bool HasFloppyEars { get => false; set => throw new NotImplementedException(); }
        public override bool HasCurlyTail { get => true; set => throw new NotImplementedException(); }
        public override bool CanSwim { get => true; set => throw new NotImplementedException(); }
        public override string Name { get => "Wolf"; set => throw new NotImplementedException(); }
        public override decimal AverageAdultWeight { get => 25.0m; set => throw new NotImplementedException(); }

        public override string MakeSound()
        {
            return "Awoo woo woo";
        }

        public override string Move()
        {
            return "Slinking";
        }
    }
}
