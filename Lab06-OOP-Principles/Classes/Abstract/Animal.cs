using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP_Principles.Classes.Abstract
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Diet { get; set; }
        public abstract decimal AverageAdultWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract string MakeSound();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string Move()
        {
            return "Moves hither and dither";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string Eat()
        {
            return $"YUM! I sure do love to be a {Diet}!";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string Sleep()
        {
            return $"The sun is down. Good night!";
        }
    }
}
