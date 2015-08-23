using UnityEngine;
using System.Collections;

public class ClickCommand: Command 
{
    Vector3 clickPosition = new Vector3();
    public ClickCommand(Vector3 _clickPosition)
    {
        clickPosition = _clickPosition;
    }

	public override void Execute(GameObject character) 
	{
        Ray clickRay = Camera.main.ScreenPointToRay(clickPosition);
        if (Physics.Raycast(clickRay))
        {

        }
	}
}
