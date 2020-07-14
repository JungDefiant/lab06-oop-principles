using Lab06_OOP_Principles.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Concrete
{
    public class Dog : Canine
    {
        private bool _livesInPack = false;
        private bool _isDomesticated = true;
        private bool _hasFloppyEars = true;
        private bool _hasCurlyTail = true;
        private bool _canSwim = true;
        private string _name = "Hairless Dog";
        private decimal _averageAdultWeight = 20.0m;

        public override bool HasFur { 
            get => base.HasFur; 
            set {
                base.HasFur = false;
            }
        }
        public override bool LivesInPack { 
            get => _livesInPack; 
            set => _livesInPack = value; 
        }
        public override bool IsDomesticated { 
            get => _isDomesticated; 
            set => _isDomesticated = value; 
        }
        public override bool HasFloppyEars { 
            get => _hasFloppyEars; 
            set => _hasFloppyEars = value; 
        }
        public override bool HasCurlyTail { 
            get => _hasCurlyTail; 
            set => _hasCurlyTail = value; 
        }
        public override bool CanSwim { 
            get => _canSwim; 
            set => _canSwim = value; 
        }
        public override string Name { 
            get => _name; 
            set => _name = value; 
        }
        public override decimal AverageAdultWeight { 
            get => _averageAdultWeight; 
            set => _averageAdultWeight = value; 
        }

        /// <summary>
        /// Makes a dog noise
        /// </summary>
        /// <returns>string expressing a dog noise</returns>
        public override string MakeSound()
        {
            return "Woof woof";
        }

        /// <summary>
        /// Makes the sound of a dog walking
        /// </summary>
        /// <returns>string expressing a dog moving</returns>
        public override string Move()
        {
            return "Tippity Tap";
        }

        /// <summary>
        /// Method that returns a string representing a dog responding to danger
        /// </summary>
        /// <returns>string expressing a dog responding to danger</returns>
        public override string RespondToDanger()
        {
            return "Bork bork bork!";
        }
    }
}
