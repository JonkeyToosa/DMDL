using UnityEngine;
using System.Collections;

public class MoveCommand : Command
{
	int xMovement = 0;
	int yMovement = 0;

    public MoveCommand (Vector2 touchPosition)
    {

    }
	public MoveCommand (int X, int Y)
	{
		xMovement = X;
		yMovement = Y;
	}

	public override void Execute(GameObject character) 
	{

	}
}

