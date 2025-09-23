extends StaticBody2D

@export var stars_required := 3
@export var player_node_path: NodePath  

func _ready() -> void:
	var player: Node = null

	
	if player_node_path != NodePath("") and player_node_path != null:
		player = get_node_or_null(player_node_path)
	
	
	if player == null:
		player = get_parent().get_node_or_null("Player")
	
	if player:
		player.connect("stars_changed", Callable(self, "_on_stars_changed"))

func _on_stars_changed(count: int) -> void:
	if count >= stars_required:
		print("Wall removed! Count:", count)
		queue_free()
