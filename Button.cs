using System;

namespace Elevator
{
    public abstract class Button
    {
        private bool _illuminate;

        public Button()
        {
            _illuminate = false;
        }

        public bool Illuminate
        {
            get { return _illuminate; }
            set { _illuminate = value; }
        }

        public abstract string Press();

        public void Release()
        {
            _illuminate = false;
        }
    }
}