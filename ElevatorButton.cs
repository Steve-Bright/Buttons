using System;

namespace Elevator
{
    public class ElevatorButton : Button
    {
        private int _floorNumber;

        public ElevatorButton(int floorNumber) : base()
        {
            _floorNumber = floorNumber;
        }

        public int FloorNumber
        {
            get { return _floorNumber; }
            set { _floorNumber = value; }
        }

        public override string Press()
        {
            Illuminate = true;
            return "You have pressed floor number: " + _floorNumber;
        }
    }
}