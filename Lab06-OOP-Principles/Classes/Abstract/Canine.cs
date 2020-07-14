using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Abstract
{
    public abstract class Canine : Animal
    {
        public override string Diet { 
            get => "omnivore"; 
            set => throw new NotImplementedException(); 
        }

        public abstract bool LivesInPack { get; set; }
        public abstract bool IsDomesticated { get; set; }
        public abstract bool HasFloppyEars { get; set; }
        public abstract bool HasCurlyTail { get; set; }
        public abstract bool CanSwim { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string Sniff()
        {
            return "Sniff, sniff";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string Swim()
        {
            return "Doggy paddling";
        }

        public virtual string MarkTerritory()
        {
            return "Whiz whiz";
        }
    }
}
