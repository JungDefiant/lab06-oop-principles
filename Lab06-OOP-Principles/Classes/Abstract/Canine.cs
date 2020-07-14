using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Abstract
{
    public abstract class Canine : Animal
    {
        protected string _diet = "omnivore";
        public override string Diet { 
            get => _diet; 
            set => _diet = value; 
        }

        protected bool _hasFur = true;
        public virtual bool HasFur
        {
            get => _hasFur;
            set => _hasFur = value;
        }

        protected int _numOfLegs = 4;
        public virtual int NumOfLegs
        {
            get => _numOfLegs;
            set => _numOfLegs = value;
        }

        public abstract bool LivesInPack { get; set; }
        public abstract bool IsDomesticated { get; set; }
        public abstract bool HasFloppyEars { get; set; }
        public abstract bool HasCurlyTail { get; set; }
        public abstract bool CanSwim { get; set; }

        /// <summary>
        /// Virtual method to return a string representation of a canine sniffing.
        /// </summary>
        /// <returns>
        /// string: a representation of a canine sniffing
        /// </returns>
        public virtual string Sniff()
        {
            return "Sniff, sniff";
        }

        /// <summary>
        /// Virtual method to return a string representation of a canine swimming.
        /// </summary>
        /// <returns>
        /// string: a representation of a canine swimming
        /// </returns>
        public virtual string Swim()
        {
            return "Doggy paddling";
        }

        /// <summary>
        /// Virtual method to return a string representation of a canine marking their territory.
        /// </summary>
        /// <returns>
        /// string: a representation of a canine marking their territory
        /// </returns>
        public virtual string MarkTerritory()
        {
            return "Whiz whiz";
        }
    }
}
