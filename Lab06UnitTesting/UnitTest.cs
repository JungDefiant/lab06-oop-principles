using System;
using Xunit;
using Lab06_OOP_Principles.Classes.Abstract;
using Lab06_OOP_Principles.Classes.Concrete;

namespace Lab06UnitTesting
{
    public class UnitTest
    {
        /// <summary>
        /// Checks whether a Shark object returns the correct output from the MakeSound() method and demonstrates inheritance from Animal class
        /// </summary>
        [Fact]
        public void CheckSharkMakesSound()
        {
            //Arrange
            Shark shark = new Shark();

            //Act
            string sharkNoise = shark.MakeSound();

            //Test
            Assert.Equal("Dun Dun Dun Dun DUN DUN", sharkNoise);
        }

        /// <summary>
        /// Checks whether a Shark object returns the correct output from the RespondToDanger() method and demonstrates inheritance from Animal class
        /// </summary>
        [Fact]
        public void CheckSharkRespondToDanger()
        {
            Shark shark = new Shark();

            string sharkResponse = shark.RespondToDanger();

            Assert.Equal("Gnaw gnaw gnaw", sharkResponse);
        }

        /// <summary>
        /// Checks whether a Dog object returns the correct output from its Move() method and demonstrates inheritance from Animal class
        /// </summary>
        [Fact]
        public void CheckDogWalks()
        {
            Dog dog = new Dog();

            string dogMove = dog.Move();

            Assert.Equal("Tippity Tap", dogMove);
        }

        /// <summary>
        /// Checks whether a Dog object returns the correct output from the MakeSound() method and demonstrates inheritance from Animal class
        /// </summary>
        [Fact]
        public void CheckDogMakesSound()
        {
            Dog dog = new Dog();

            string dogSound = dog.MakeSound();

            Assert.Equal("Woof woof", dogSound);
        }

        /// <summary>
        /// Checks whether a Wolf object returns the correct output from the Move() method and demonstrates inheritance from Animal class
        /// </summary>
        [Fact]
        public void CheckWolfMove()
        {
            Wolf wolf = new Wolf();

            string wolfMove = wolf.Move();

            Assert.Equal("Slinking", wolfMove);
        }

        /// <summary>
        /// Checks whether a Wolf object returns the correct output from the RespondToDanger() method and demonstrates inheritance from Animal class
        /// </summary>
        [Fact]
        public void CheckWolfRespondToDanger()
        {
            Wolf wolf = new Wolf();

            string wolfResponse = wolf.RespondToDanger();

            Assert.Equal("Grrrrrr!", wolfResponse);
        }

        /// <summary>
        /// Checks whether a Rhino object returns the correct output from the MakeSound() method and demonstrates inheritance from Animal class
        /// </summary>
        [Fact]
        public void CheckRhinoMoos()
        {
            Rhino rhino = new Rhino();

            string rhinoSound = rhino.MakeSound();

            Assert.Equal("Moooo", rhinoSound);
        }

        /// <summary>
        /// Checks whether a Rhino object returns the correct output from the Move() method and demonstrates inheritance from Animal class
        /// </summary>
        [Fact]
        public void CheckRhinoMove()
        {
            Rhino rhino = new Rhino();

            string rhinoMove = rhino.Move();

            Assert.Equal("Rumble but slower", rhinoMove);
        }

        /// <summary>
        /// Checks whether a Hippo object returns the correct output from the Charge() method and demonstrates inheritance from Pachyderm class
        /// </summary>
        [Fact]
        public void CheckHippoCharge()
        {
            Hippo hippo = new Hippo();

            string hippoCharge = hippo.Charge();

            Assert.Equal("Rumble rumble", hippoCharge);
        }

        /// <summary>
        /// Checks whether a Hippo object returns the correct output from the RespondToDanger() method and demonstrates inheritance from Animal class
        /// </summary>
        [Fact]
        public void CheckHippoRespondToDanger()
        {
            Hippo hippo = new Hippo();

            string hippoResponse = hippo.RespondToDanger();

            Assert.Equal("Shows off those mean chompers!", hippoResponse);
        }

        /// <summary>
        /// Checks whether a Dog object's Move() method returns a string
        /// </summary>
        [Fact]
        public void CheckDogTypeOfMoves()
        {
            Dog dog = new Dog();
            Assert.IsType<string>(dog.Move());
        }

        /// <summary>
        /// Checks whether a Rhino object's CanBeRidden property returns a bool
        /// </summary>
        [Fact]
        public void CheckRhinoTypeOfCanBeRidden()
        {
            Rhino rhino = new Rhino();
            Assert.IsType<bool>(rhino.CanBeRidden);
        }

        /// <summary>
        /// Checks whether a Shark object's AverageAdultWeight property returns a decimal
        /// </summary>
        [Fact]
        public void CheckSharkTypeOfAverageAdultWeight()
        {
            Shark shark = new Shark();
            Assert.IsType<decimal>(shark.AverageAdultWeight);
        }
    }
}
