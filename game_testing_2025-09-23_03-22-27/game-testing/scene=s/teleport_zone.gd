extends Area2D

@export var start_point: NodePath

func _on_body_entered(body: Node) -> void:
	if body is CharacterBody2D and start_point != null:
		var sp = get_node(start_point)
		body.global_position = sp.global_position
		
		body.velocity = Vector2.ZERO
