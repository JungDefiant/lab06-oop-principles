using Lab06_OOP_Principles.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Concrete
{
    public class Wolf : Canine
    {
        private bool _livesInPack = true;
        private bool _isDomesticated = false;
        private bool _hasFloppyEars = false;
        private bool _hasCurlyTail = true;
        private bool _canSwim = true;
        private string _name = "Wolf";
        private decimal _averageAdultWeight = 25.0m;

        public override bool LivesInPack
        {
            get => _livesInPack;
            set => _livesInPack = value;
        }
        public override bool IsDomesticated
        {
            get => _isDomesticated;
            set => _isDomesticated = value;
        }
        public override bool HasFloppyEars
        {
            get => _hasFloppyEars;
            set => _hasFloppyEars = value;
        }
        public override bool HasCurlyTail
        {
            get => _hasCurlyTail;
            set => _hasCurlyTail = value;
        }
        public override bool CanSwim
        {
            get => _canSwim;
            set => _canSwim = value;
        }
        public override string Name
        {
            get => _name;
            set => _name = value;
        }
        public override decimal AverageAdultWeight
        {
            get => _averageAdultWeight;
            set => _averageAdultWeight = value;
        }

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

        public override string RespondToDanger()
        {
            return "Grrrrrr!";
        }
    }
}
