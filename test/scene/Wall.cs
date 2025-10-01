using Godot;
using System;

public partial class Wall : StaticBody2D
{
	[Export]
	public int StarsRequired = 3;

	[Export]
	public NodePath PlayerNodePath;

	public override void _Ready()
	{
		Node player = null;

		if (PlayerNodePath != null && PlayerNodePath.ToString() != String.Empty)
			player = GetNodeOrNull(PlayerNodePath);

		if (player == null)
			player = GetParent().GetNodeOrNull("Player");

		if (player != null)
			_ = player.Connect("stars_changed", new Callable(this, nameof(OnStarsChanged)));
	}

	private void OnStarsChanged(int count)
	{
		if (count >= StarsRequired)
		{
			GD.Print("Wall removed! Count: " + count);
			QueueFree();
		}
	}
}
