using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeakerGame.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeakerGame.Logic.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void 비어있는비커로이동하는경우()
        {
            Game game = new Game();
            game.Move("A", "C");
            // Console.WriteLine(game.GetLiter("A")); // 5
            Assert.AreEqual(5, game.GetLiter("A"));

            // Console.WriteLine(game.GetLiter("C")); // 3
            Assert.AreEqual(3, game.GetLiter("C"));
        }

        [TestMethod()]
        public void 비어있는않은비커로이동하는경우()
        {
            Game game = new Game();
            game.Move("A", "C");
            game.Move("C", "A");

            Assert.AreEqual(8, game.GetLiter("A"));
            Assert.AreEqual(0, game.GetLiter("C"));
        }

        [TestMethod()]
        public void IsCompletedTest()
        {
            Game game = new Game();
            game.Move("A", "B");
            game.Move("B", "C");
            game.Move("C", "A");
            game.Move("B", "C");
            game.Move("A", "B");
            game.Move("B", "C");
            game.Move("C", "A");

            Assert.AreEqual(true, game.IsCompleted());
        }
    }
}