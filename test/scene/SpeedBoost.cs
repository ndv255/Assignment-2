using Godot;
using System;

public partial class SpeedBoost : Area2D
{
	// Declare the signal
	public event Action OnSpeedBoosted;

	public void _on_body_entered(Node body)
	{
		if (body.Name == "Player")
		{
			OnSpeedBoosted?.Invoke();
		}
	}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
