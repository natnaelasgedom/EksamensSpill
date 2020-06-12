using EksamenSpill;
using NUnit.Framework;

namespace EksamenSpillTest
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Robot_BeOmKommando_Test()
        {
            Robot robot = new Robot();
            int robotChoice = robot.BeOmKommando("Spørsmål?", new string[] { "bla1", "bla2", "bla3", "bla4"});
            Assert.IsTrue(robotChoice<=4);
        }
    }
}