using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Abstract
{
    public abstract class Pachyderm : Animal
    {
        public abstract bool IsDomestic { get; set; }
        public abstract bool CanBeRidden { get; set; }
        public abstract int NumberOfHorns { get; set; }
        public abstract bool CanSwim { get; set; }
        public abstract bool HasTrunk { get; set; }

        /// <summary>
        /// Returns a string expressing the pachyderm charging
        /// </summary>
        /// <returns>string expressing sound of animal charging</returns>
        public virtual string Charge()
        {
            return "Rumble rumble";
        }

        /// <summary>
        /// Returns a string expressing the pachyderm rolling around
        /// </summary>
        /// <returns>string expressing sound of animal rolling around</returns>
        public virtual string RollAround()
        {
            return "Roll roll";
        }
    }
}
