using Lab06_OOP_Principles.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Concrete
{
    public class Hippo : Pachyderm
    {
        private bool _isDomestic = false;
        private bool _canBeRidden = false;
        private int _numberOfHorns = 0;
        private bool _canSwim = true;
        private bool _hasTrunk = false;
        private string _name = "Hippo";
        private string _diet = "herbivore";
        private decimal _averageAdultWeight = 1500.0m;

        public override bool IsDomestic
        {
            get => _isDomestic;
            set => _isDomestic = value;
        }
        public override bool CanBeRidden
        {
            get => _canBeRidden;
            set => _canBeRidden = value;
        }
        public override int NumberOfHorns
        {
            get => _numberOfHorns;
            set => _numberOfHorns = value;
        }
        public override bool CanSwim
        {
            get => _canSwim;
            set => _canSwim = value;
        }
        public override bool HasTrunk
        {
            get => _hasTrunk;
            set => _hasTrunk = value;
        }
        public override string Name
        {
            get => _name;
            set => _name = value;
        }
        public override string Diet
        {
            get => _diet;
            set => _diet = value;
        }
        public override decimal AverageAdultWeight
        {
            get => _averageAdultWeight;
            set => _averageAdultWeight = value;
        }

        /// <summary>
        /// Makes a hippo noise
        /// </summary>
        /// <returns>string expressing a hippo noise</returns>
        public override string MakeSound()
        {
            return "Hippo noises";
        }

        /// <summary>
        /// Makes the sound of a hippo moving
        /// </summary>
        /// <returns>string expressing a hippo moving</returns>
        public override string Move()
        {
            return "Waddle waddle";
        }

        /// <summary>
        /// Method that returns a string expressing a hippo responding to danger
        /// </summary>
        /// <returns>string expressing a hippo responding to danger</returns>
        public override string RespondToDanger()
        {
            return "Shows off those mean chompers!";
        }
    }
}
