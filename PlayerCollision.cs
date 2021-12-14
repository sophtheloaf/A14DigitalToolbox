//using UnityEngine;

//public class PlayerCollision : MonoBehaviour {

//	public PlayerMovement movement;     // A reference to our PlayerMovement script
	
//	void Start()
//	{
//		//GameObject player = GameObject.Find("player");
//		//PlayerMovement playerMovement = player.GetComponent<playerMovement>();
//		//playerMovement.forwardForce -= 10.0f;
//		GameObject.Find("Player").GetComponent<PlayerMovement>().forwardForce += 2f;
//	}

//// This function runs when we hit another object.
//// We get information about the collision and call it "collisionInfo".
//void OnCollisionEnter (Collision collisionInfo)
//	{
//		// We check if the object we collided with has a tag called "Obstacle".
//		if (collisionInfo.collider.tag == "Obstacle")
//		{
//			movement.enabled = false;   // Disable the players movement.
//			FindObjectOfType<GameManager>().EndGame();
//		}
//		if (collisionInfo.collider.tag == "Cheese")
//		{
//			GameObject.Find("Player").GetComponent<PlayerMovement>().forwardForce += 2f;
//			Destroy(GetComponent<Collider>());
//		}
//	}
//}

using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

	public PlayerMovement movement;     // A reference to our PlayerMovement script

	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter(Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().EndGame();
		}
	}

	void OnTriggerEnter(Collider collisionInfo)
	{
		if (collisionInfo.tag == "Slowdown")
		{
			GameObject.Find("Player").GetComponent<PlayerMovement>().forwardForce -= 2.0f;
		}
	}
}