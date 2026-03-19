using Godot;
using System;

public partial class Player : CharacterBody2D
{
	float speed = 5f;

	public override void _Process(double delta)
	{
		if(Input.IsActionPressed("up"))
		{
			this.Position += new Vector2(0, -speed);
		}
		if(Input.IsActionPressed("down"))
		{
			this.Position += new Vector2(0, speed);
		}
		if(Input.IsActionPressed("left"))
		{
			this.Position += new Vector2(-speed, 0);
		}
		if(Input.IsActionPressed("right"))
		{
			this.Position += new Vector2(speed, 0);
		}
	}
}
