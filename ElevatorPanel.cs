using System;
using System.Collections.Generic;
using Elevator;

public class ElevatorPanel
{
    private List<Button> _buttons;

    public ElevatorPanel()
    {
        _buttons = new List<Button>();
    }

    public List<Button> Buttons
    {
        get { return _buttons; }
    }

    public void AddButton(Button button)
    {
        _buttons.Add(button);
    }

    public List<Button> retrieveIlluminateButtons()
    {
        List<Button> illuminatedButtons = new List<Button>();
        foreach (Button eachButton in _buttons)
        {
            if (eachButton.Illuminate == true)
            {
                illuminatedButtons.Add(eachButton);
            }
        }
        return illuminatedButtons;
    }

    public void Reset()
    {
        foreach (Button eachButton in _buttons)
        {
            eachButton.Illuminate = false;
        }
    }
}
