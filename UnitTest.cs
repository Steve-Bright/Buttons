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

            Assert.AreEqual(pressedString, "You are moving up from floor number 3");
        }


        [Test()]
        public void TestButtonCollectionCounts()
        {
            FloorButton floorButton = new FloorButton(1, Direction.Up);
            ElevatorButton elevatorButton = new ElevatorButton(1);
            ElevatorPanel elevatorPanel = new ElevatorPanel();
            elevatorPanel.AddButton(floorButton);
            elevatorPanel.AddButton(elevatorButton);

            Assert.AreEqual(elevatorPanel.Buttons.Count, 2);
        }
    }
}