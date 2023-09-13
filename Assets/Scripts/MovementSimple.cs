using UnityEngine;

public class MovementSimple : MonoBehaviour
{
	float speed = 5f;
	Vector2 position;

	private void Start()
	{
		//Set position to our current positon (from the editor)
		position = transform.position;
	}

	void Update()
	{
		//Get input from the user, multiply with speed and add to our position
		position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

		//Please note that this movement is not normalized and therefore 
		//moves faster when going diagonally

		//Move our transform based to our updated position.
		transform.position = position;
	}
}
