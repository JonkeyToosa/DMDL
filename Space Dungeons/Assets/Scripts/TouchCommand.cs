using UnityEngine;
using System.Collections;

public class TouchCommand: Command 
{
    public TouchCommand(Vector2 touchPosition)
    {
        Ray touchRay = Camera.main.ScreenPointToRay(touchPosition);
        if (Physics.Raycast(touchRay))
        {
            Debug.Log("Clicked something!");
        }
    }

	public override void Execute(GameObject character) 
	{
       
	}
}
