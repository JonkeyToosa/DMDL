using UnityEngine;
using System.Collections;

public class InputHandler: MonoBehaviour
{
	public UI.Controls controls;

	private Command currentCommand = null;
	private JumpCommand jumpCommand;
	private FireCommand fireCommand;

	public GameObject character;

	public void Update ()
	{
		currentCommand = HandleInput ();
        if (currentCommand != null)
            currentCommand.Execute(character);
	}

	private Command HandleInput()
	{
        // Deal with arrow key movements
		if (Input.GetKeyDown(controls.UP_BUTTON))
			return new MoveCommand(0, 1);
		if (Input.GetKeyDown(controls.DOWN_BUTTON))
			return new MoveCommand(0, -1);
		if (Input.GetKeyDown(controls.RIGHT_BUTTON))
			return new MoveCommand (1, 0);
		if (Input.GetKeyDown(controls.LEFT_BUTTON))
			return new MoveCommand(-1, 0);

        // Deal with touches/clicks on the screen
        if (controls.PRIMARY_INPUT == UI.Controls.inputChoice.Touch && Input.touchCount > 0)
            return new TouchCommand(Input.GetTouch(0).position);

        if (controls.PRIMARY_INPUT == UI.Controls.inputChoice.Click && Input.GetMouseButtonDown(0))
            return new ClickCommand(Input.mousePosition);
		
		return null;
	}

    //#region Touch Intepriter
    //private Command HandleTouches ()
    //{
    //    return new Tou(Input.GetTouch(0).position);
    //}
    //#endregion
}

