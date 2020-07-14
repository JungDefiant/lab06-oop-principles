using System;
using Xunit;
using Lab06_OOP_Principles.Classes.Abstract;
using Lab06_OOP_Principles.Classes.Concrete;

namespace Lab06UnitTesting
{
    public class UnitTest
    {
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

        [Fact]
        public void CheckDogWalks()
        {
            Dog dog = new Dog();

            string dogMove = dog.Move();

            Assert.Equal("Tippity Tap", dogMove);
        }

        [Fact]
        public void CheckWolfMove()
        {
            Wolf wolf = new Wolf();

            string wolfMove = wolf.Move();

            Assert.Equal("Slinking", wolfMove);
        }

        [Fact]
        public void CheckRhinoMoos()
        {
            Rhino rhino = new Rhino();

            string rhinoSound = rhino.MakeSound();

            Assert.Equal("Moooo", rhinoSound);
        }

        [Fact]
        public void CheckHippoCharge()
        {
            Hippo hippo = new Hippo();

            string hippoCharge = hippo.Charge();

            Assert.Equal("Rumble rumble", hippoCharge);
        }

        [Fact]
        public void CheckDogTypeOfMoves()
        {
            Dog dog = new Dog();
            Assert.IsType<string>(dog.Move());
        }

        [Fact]
        public void CheckRhinoTypeOfCanBeRidden()
        {
            Rhino rhino = new Rhino();
            Assert.IsType<bool>(rhino.CanBeRidden);
        }

        [Fact]
        public void CheckSharkTypeOfAverageAdultWeight()
        {
            Shark shark = new Shark();
            Assert.IsType<decimal>(shark.AverageAdultWeight);
        }
    }
}
