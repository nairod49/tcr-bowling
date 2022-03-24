using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQuillesDown()
        {
            // Test si toutes les quilles sont tombées

            int nbquilleInit = 10;
            int nbquillesDown = 10;

            // Assert
            Assert.AreEqual(nbquilleInit, nbquillesDown, 0.001, "Il reste des quilles à faire tomber");
        }

        [TestMethod]
        public void TestQuillesDown2()
        {
            // Test si toutes les quilles sont tombées

            int nbquilleInit = 10;
            int nbquillesDown = 9;

            // Assert
            Assert.AreEqual(nbquilleInit, nbquillesDown, 0.001, "Il reste des quilles à faire tomber");
        }
    }
}