using Lab06_OOP_Principles.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Concrete
{
    public class Shark : Fish
    {
        private int _numberOfFins = 5;
        private decimal _swimSpeed = 25.0m;
        private bool _isBottomFeeder = false;
        private string _name = "Shark";
        private string _diet = "carnivore";
        private decimal _averageAdultWeight = 500.0m;
        
        public override int NumberOfFins { 
            get => _numberOfFins; 
            set => _numberOfFins = value; 
        }
        public override decimal SwimSpeed { 
            get => _swimSpeed; 
            set => _swimSpeed = value; 
        }
        public override bool IsBottomFeeder { 
            get => _isBottomFeeder; 
            set => _isBottomFeeder = value; 
        }
        public override string Name { 
            get => _name; 
            set => _name = value; 
        }
        public override string Diet { 
            get => _diet; 
            set => _diet = value; 
        }
        public override decimal AverageAdultWeight { 
            get => _averageAdultWeight; 
            set => _averageAdultWeight = value; 
        }

        /// <summary>
        /// Method that overrides the abstract parent class method to give a string representation a shark's sound.
        /// </summary>
        /// <returns>
        /// string: a representation of a shark's sound
        /// </returns>
        public override string MakeSound()
        {
            return "Dun Dun Dun Dun DUN DUN";
        }

        /// <summary>
        /// Method that overrides the virtual parent class method to give a string representation a shark's movement.
        /// </summary>
        /// <returns>
        /// string: a representation of a shark's movement
        /// </returns>
        public override string Move()
        {
            return "Swim swim";
        }

        /// <summary>
        /// Method that returns a string representing a shark responding to danger
        /// </summary>
        /// <returns>string representing a shark responding to danger</returns>
        public override string RespondToDanger()
        {
            return "Gnaw gnaw gnaw";
        }
    }
}
