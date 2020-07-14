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

        /// <summary>
        /// Returns a string expressing the fish breathing water
        /// </summary>
        /// <returns>string expressing the fish breathing water</returns>
        public virtual string BreatheUnderwater()
        {
            return "Bloop bloop";
        }

        /// <summary>
        /// Checks whether fish finds a school
        /// </summary>
        /// <param name="foundSchool"></param>
        /// <returns>bool indicating whether fish found school</returns>
        public virtual bool FindASchool(bool foundSchool)
        {
            return foundSchool;
        }
    }
}
