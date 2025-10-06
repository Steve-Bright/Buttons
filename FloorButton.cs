using System;

namespace Elevator
{
    public class FloorButton : Button
    {
        private int _currFloorNumber;
        private Direction _direction;

        public FloorButton(int currFloorNumber, Direction direction) : base()
        {
            _currFloorNumber = currFloorNumber;
            _direction = direction;
        }

        public override string Press()
        {

            if (_direction == Direction.Up)
            {
                Illuminate = true;
                return "You are moving up from floor number " + _currFloorNumber;
            }
            else
            {
                return "You are moving down from floor number " + _currFloorNumber;
            }
        }
    }
}