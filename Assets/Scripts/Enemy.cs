using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float speed = 3; //How fast we are moving
	public GameObject enemy;  //Reference to our enemy prefab so we can create more

	Transform target; //Our movement target
	Rigidbody2D rb2D; //ref to our rigidbody component

	// Start is called before the first frame update
	void Start()
	{
		//Find our target, it's the object with the tag "Player"
		//Don't forget to set the tag on our player.
		target = GameObject.FindGameObjectWithTag("Player").transform;

		//get the ref to our rigidbody so we don't have to look for it each frame.
		rb2D = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		//Calculate what direction we should move.
		Vector2 direction = target.position - transform.position;

		//Normalize, we just want the direction
		direction.Normalize();

		//set velocity in the direction of the player
		rb2D.velocity = direction * speed;
        transform.right = target.position - transform.position;
    }

	//This function is called by Unity on collision.
	private void OnCollisionEnter2D(Collision2D other)
	{
		//If we have collided with an object that has a laser component
		//It's like a double negative here, tricky.
		if (other.gameObject.GetComponent<Laser>() != null)
		{
			//get some random coordinates for our new enemies
			float x = Random.Range(-10, 10);
			float y = Random.Range(-10, 10);

			//Spawn 2 new enemies.
			
			//Call the function Death() after a 0.01f delay
			//we needed this delay because runnint instantiate and destroy
			//on the same frame caused issues.
			//this is quite a bad solution for this.
			Invoke("Death", 0.01f);

			//Destroy the laser
			Destroy(other.gameObject);
		}
	}

	void Death()
	{
		ScoreManager sm = FindAnyObjectByType<ScoreManager>();
		sm.IncreaseScore(1);
		//Destroy the enemy
		Destroy(gameObject);
	}
}
