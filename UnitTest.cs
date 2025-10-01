using System;
using NUnit.Framework;


namespace Elevator
{
    [TestFixture()]
    public class UnitTest
    {
        [Test()]
        public void TestFloorButtonPressed()
        {
            FloorButton newButton = new FloorButton(3, Direction.Up);

            string pressedString = newButton.Press();

            Assert.AreEqual(pressedString, "You are moving up from floor number 3" );
        }
    }
}