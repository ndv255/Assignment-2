extends Area2D

signal collected

func _ready() -> void:
	connect("body_entered", Callable(self, "_on_body_entered"))

func _on_body_entered(body: Node) -> void:
	if body is CharacterBody2D and body.has_method("collect_star"):
		body.collect_star()
		queue_free()
