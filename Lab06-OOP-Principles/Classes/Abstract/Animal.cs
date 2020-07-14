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
        /// Abstract method whose concrete implementation will return a string representation of the sound the animal makes.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete animal object's sound
        /// </returns>
        public abstract string MakeSound();

        /// <summary>
        /// Abstract method that returns a string representing how the animal responds to danger.
        /// </summary>
        /// <returns>
        /// string: a representation of the animal object's response to danger
        /// </returns>
        public abstract string RespondToDanger();

        /// <summary>
        /// Virtual method whose that returns a string representation of the concrete animal's movement.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete animal object's movement
        /// </returns>
        public virtual string Move()
        {
            return "Moves hither and dither";
        }

        /// <summary>
        /// Virtual method that returns a string representation of the concrete animal's eating.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete animal object's eating
        /// </returns>
        public virtual string Eat()
        {
            return $"YUM! I sure do love to be a {Diet}!";
        }

        /// <summary>
        /// Virtual method that returns a string representation of the concrete animal's Sleep.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete animal object's sleeping
        /// </returns>
        public virtual string Sleep()
        {
            return $"The sun is down. Good night!";
        }
    }
}
