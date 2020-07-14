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

        /// <summary>
        /// Method that overrides the virtual parent class method to give a string representation a wolf's sound.
        /// </summary>
        /// <returns>
        /// string: a representation of a wolf's sound
        /// </returns>
        public override string MakeSound()
        {
            return "Awoo woo woo";
        }

        /// <summary>
        /// Method that overrides the virtual parent class method to give a string representation a wolf's movement.
        /// </summary>
        /// <returns>
        /// string: a representation of a wolf's movement
        /// </returns>
        public override string Move()
        {
            return "Slinking";
        }
    }
}
