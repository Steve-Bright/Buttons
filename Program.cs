using System;
using SplashKitSDK;

namespace Elevator
{
    public class Program
    {
        public static void Main()
        {
            // Instantiate an ElevatorButton object and a FloorButton object

            FloorButton floorButton = new FloorButton(1, Direction.Up);
            ElevatorButton elevatorButton = new ElevatorButton(1);

            // Press the FloorButton object created and display the
            floorButton.Press();
            // Instantiate an ElevatorPanel object and add the two Button objects
            ElevatorPanel elevatorPanel = new ElevatorPanel();
            elevatorPanel.AddButton(floorButton);
            elevatorPanel.AddButton(elevatorButton);
            // Display the number of illuminate buttons in the ElevatorPanel
            Console.WriteLine("Numbe of illumiate buttons {0}" ,elevatorPanel.retrieveIlluminateButtons().Count);
            // Reset the ElevatorPanel
            Console.ReadLine();
            elevatorPanel.Reset();
        }
    }
}
