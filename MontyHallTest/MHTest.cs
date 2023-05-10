using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monty_Hall_Simulation;
using System;

namespace MontyHallTest
{
    [TestClass]
    public class MHTest
    {
        [TestMethod]
        public void TestStartGameFalse1()
        {
            //Arrange
            var form = new Form1();
            var numberOfGames = 10000;
            var changeDoor = false;

            //Act
            form.StartGame(numberOfGames, changeDoor);

            //Assert
            var expectedProbability = 1.0 / 3.0; //Expected probability for not changing door
            var actualProbability = (double)form.numberOfWins / numberOfGames;
            Assert.AreEqual(expectedProbability, actualProbability, 0.01);

            Console.WriteLine($"Actual probability: {actualProbability:P4}");
            Console.WriteLine($"Expected probability: {expectedProbability:P4}");
        }
        [TestMethod]
        public void TestStartGameFalse2()
        {
            //Arrange
            var form = new Form1();
            var numberOfGames = 100000;
            var changeDoor = false;

            //Act
            form.StartGame(numberOfGames, changeDoor);

            //Assert
            var expectedProbability = 1.0 / 3.0; //Expected probability for changing door
            var actualProbability = (double)form.numberOfWins / numberOfGames;
            Assert.AreEqual(expectedProbability, actualProbability, 0.01);

            Console.WriteLine($"Actual probability: {actualProbability:P4}");
            Console.WriteLine($"Expected probability: {expectedProbability:P4}");
        }
        [TestMethod]
        public void TestStartGameFalse3()
        {
            //Arrange
            var form = new Form1();
            var numberOfGames = 1000000;
            var changeDoor = false;

            //Act
            form.StartGame(numberOfGames, changeDoor);

            //Assert
            var expectedProbability = 1.0 / 3.0; //Expected probability for changing door
            var actualProbability = (double)form.numberOfWins / numberOfGames;
            Assert.AreEqual(expectedProbability, actualProbability, 0.01);

            Console.WriteLine($"Actual probability: {actualProbability:P4}");
            Console.WriteLine($"Expected probability: {expectedProbability:P4}");
        }
        [TestMethod]
        public void TestStartGameTrue1()
        {
            //Arrange
            var form = new Form1();
            var numberOfGames = 10000;
            var changeDoor = true;

            //Act
            form.StartGame(numberOfGames, changeDoor);

            //Assert
            var expectedProbability = 2.0 / 3.0; //Expected probability for changing door
            var actualProbability = (double)form.numberOfWins / numberOfGames;
            Assert.AreEqual(expectedProbability, actualProbability, 0.01);

            Console.WriteLine($"Actual probability: {actualProbability:P4}");
            Console.WriteLine($"Expected probability: {expectedProbability:P4}");
        }
        [TestMethod]
        public void TestStartGameTrue2()
        {
            //Arrange
            var form = new Form1();
            var numberOfGames = 100000;
            var changeDoor = true;

            //Act
            form.StartGame(numberOfGames, changeDoor);

            //Assert
            var expectedProbability = 2.0 / 3.0; //Expected probability for changing door
            var actualProbability = (double)form.numberOfWins / numberOfGames;
            Assert.AreEqual(expectedProbability, actualProbability, 0.01);

            Console.WriteLine($"Actual probability: {actualProbability:P4}");
            Console.WriteLine($"Expected probability: {expectedProbability:P4}");

        }
        [TestMethod]
        public void TestStartGameTrue3()
        {
            //Arrange
            var form = new Form1();
            var numberOfGames = 1000000;
            var changeDoor = true;

            //Act
            form.StartGame(numberOfGames, changeDoor);

            //Assert
            var expectedProbability = 2.0 / 3.0; //Expected probability for changing door
            var actualProbability = (double)form.numberOfWins / numberOfGames;
            Assert.AreEqual(expectedProbability, actualProbability, 0.01);

            Console.WriteLine($"Actual probability: {actualProbability:P4}");
            Console.WriteLine($"Expected probability: {expectedProbability:P4}");

        }
    }
}

