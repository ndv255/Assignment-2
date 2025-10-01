using Godot;
using System;

public partial class SpeedBoost : Area2D
{
    [Signal]
    public delegate void SpeedBoostedEventHandler();

    public override void _Ready()
    {
        BodyEntered += OnBodyEntered;
    }

    private void OnBodyEntered(Node body)
	{
		if (body.Name == "Player")
		{
            EmitSignal(nameof(SpeedBoostedEventHandler));
		}
	}
}