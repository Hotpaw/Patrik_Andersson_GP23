using UnityEngine;

public class Laser : MonoBehaviour
{
	public GameObject explosion; //Reference to our explosion object

	// Start is called before the first frame update
	void Start()
	{
		AudioManager audioManager = FindObjectOfType<AudioManager>();
		audioManager.PlaySound("Laser");
		//Destroy ourself after 10 seconds
		Destroy(gameObject, 10);
	}

	// Update is called once per frame
	void Update()
	{
		//Move in the direction of our own up direction
		transform.position += transform.up * 30 * Time.deltaTime;
	}

	//Unity Collision function
	//Called when a rigidbody2D gameObject collides with a collider2D
	private void OnCollisionEnter2D(Collision2D collision)
	{
		//Change our color to green
		GetComponent<SpriteRenderer>().color = Color.green;
        AudioManager audioManager = FindObjectOfType<AudioManager>();
		audioManager.PlaySound("Explosion");
        //Create a new explosion and save that explosion in a variable.
        GameObject newExplosion = Instantiate(explosion, transform.position, transform.rotation);

		if (collision.gameObject.CompareTag("Enemy"))
		{
			collision.gameObject.GetComponent<Enemy>().TakeDamage();
		}
        //Destroy the newly created explosion object after 1 second.
        Destroy(newExplosion, 1);
	}
}
