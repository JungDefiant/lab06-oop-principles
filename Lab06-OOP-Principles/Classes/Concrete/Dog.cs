using Lab06_OOP_Principles.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Concrete
{
    public class Dog : Canine
    {
        public override bool LivesInPack { get => false; set => throw new NotImplementedException(); }
        public override bool IsDomesticated { get => true; set => throw new NotImplementedException(); }
        public override bool HasFloppyEars { get => true; set => throw new NotImplementedException(); }
        public override bool HasCurlyTail { get => true; set => throw new NotImplementedException(); }
        public override bool CanSwim { get => true; set => throw new NotImplementedException(); }
        public override string Name { get => "Dog"; set => throw new NotImplementedException(); }
        public override decimal AverageAdultWeight { get => 20.0m; set => throw new NotImplementedException(); }

        public override string MakeSound()
        {
            return "Woof woof";
        }

        public override string Move()
        {
            return "Tippity tap";
        }
    }
}
