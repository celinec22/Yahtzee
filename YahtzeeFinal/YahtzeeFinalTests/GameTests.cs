using Microsoft.VisualStudio.TestTools.UnitTesting;
using YahtzeeFinal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeFinal.Tests
{
    [TestClass()]
    public class GameTests
    {




        [TestMethod()]
        public void RollTest()
        {
            //Arrange
            Game game = new Game();
            int[] dice = new int[5] { 1, 1, 1, 1, 1 };
            int[] expectedlist =new int[5] {1,1, 1, 1, 1, 1};
            // Act
            int actualnum = game.Roll(dice);

            //Assert
            Assert.AreEqual(expectedlist, actuallist);
        }

        [TestMethod()]
        public void AcesTest()
        {
            //Arrange
            Game game = new Game();
            int[] dice = new int[5] { 1, 1, 1, 1, 1 };
            int expectednum = 5;
            // Act
            int actualnum = game.Aces(dice);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void TwosTest()
        {
            //Arrange
            Game z = new Game();
            int[] dice2 = new int[5] { 2, 2, 2, 2, 2 };
            int expectednum = 10;
            // Act
            int actualnum = z.Twos(dice2);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void ThreesTest()
        {
            //Arrange
            Game n = new Game();
            int[] dice3 = new int[5] { 3, 3, 3, 3, 3 };
            int expectednum = 15;
            // Act
            int actualnum = n.Threes(dice3);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void FoursTest()
        {
            //Arrange
            Game b = new Game();
            int[] dice4 = new int[5] { 4, 3, 3, 3, 3 };
            int expectednum = 4;
            // Act
            int actualnum = b.Fours(dice4);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void FivesTest()
        {
            //Arrange
            Game j = new Game();
            int[] dice5 = new int[5] { 5, 3, 3, 3, 3 };
            int expectednum = 5;
            // Act
            int actualnum = j.Fives(dice5);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void SixesTest()
        {
            //Arrange
            Game j = new Game();
            int[] dice5 = new int[5] { 6, 3, 3, 3, 3 };
            int expectednum = 6;
            // Act
            int actualnum = j.Sixes(dice5);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void ThreeOfAKindTest()
        {
            //Arrange
            Game j = new Game();
            int[] dice5 = new int[5] { 6, 6, 3, 3, 3 };
            int expectednum = 9;
            // Act
            int actualnum = j.ThreeOfAKind(dice5);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void FourOfAKindTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void YahtzeeTest()
        {
            //Arrange
            Game l = new Game();
            int[] dice2 = new int[5] { 3, 3, 3, 3, 3 };
            int expectednum = 50;
            // Act
            int actualnum = l.Yahtzee(dice2);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void FuleTest()
        {
            Game l = new Game();
            int[] dice2 = new int[5] { 2, 2, 3, 3, 3 };
            int expectednum = 25;
            // Act
            int actualnum = l.Fule(dice2);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void ChanceTest()
        {
            Game l = new Game();
            int[] dice2 = new int[5] { 2, 2, 3, 3, 3 };
            int expectednum = 13;
            // Act
            int actualnum = l.Chance(dice2);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void SmallSTest()
        {
            Game l = new Game();
            int[] dice2 = new int[5] { 1, 2, 3, 4, 6 };
            int expectednum = 30;
            // Act
            int actualnum = l.SmallS(dice2);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void LargeSTest()
        {
            Game l = new Game();
            int[] dice2 = new int[5] { 1, 2, 3, 4, 5 };
            int expectednum = 40;
            // Act
            int actualnum = l.LargeS(dice2);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void TotalPlayer1ScoreTest()
        {
            Game l = new Game();
            int[] dice2 = new int[5] { 1, 1, 1, 1, 1 };
            int[] dice3 = new int[5] { 1, 1, 1, 1, 1 };
            int expectednum = 10;
            // Act
            int actualnum = l.TotalPlayer1Score(dice2, dice3);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }

        [TestMethod()]
        public void GameScoreTest()
        {
            Game l = new Game();
            int[] dice2 = new int[5] { 1, 1, 1, 1, 1 };

            int expectednum = 5;
            // Act
            int actualnum = l.GameScore(dice2);

            //Assert
            Assert.AreEqual(expectednum, actualnum);
        }
    }
}