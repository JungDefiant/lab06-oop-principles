using System;
using Xunit;
using Lab06_OOP_Principles;

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

        [Theory]
        public void CheckMoves(Animal animal)
        {
            Type type = typeof animal.Move();

            Assert.Equal(Type.GetType("string"), type);
        }
    }
}
