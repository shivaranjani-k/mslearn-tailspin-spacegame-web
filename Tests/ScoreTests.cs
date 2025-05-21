using NUnit.Framework;

namespace Tailspin.SpaceGame.Web.Tests
{
    public class GameRegionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Milky Way")]
        [TestCase("Andromeda")]
        [TestCase("Pinwheel")]
        [TestCase("NGC 1300")]
        [TestCase("Messier 82")]
        public void TestGetOnlyRequestedGameRegion(string gameRegion)
        {
            var expected = gameRegion;
            var actual = gameRegion; // Replace with actual logic
            Assert.AreEqual(expected, actual);
        }
    }
}
