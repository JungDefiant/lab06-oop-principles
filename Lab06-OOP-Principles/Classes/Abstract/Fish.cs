using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Abstract
{
    public abstract class Fish : Animal
    {
        public abstract int NumberOfFins { get; set; }
        public abstract decimal SwimSpeed { get; set; }
        public abstract bool IsBottomFeeder { get; set; }

        public virtual string BreatheUnderwater()
        {
            return "Bloop bloop";
        }

        public virtual bool FindASchool(bool foundSchool)
        {
            return foundSchool;
        }
    }
}
