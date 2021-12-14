using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;

	// Update is called once per frame
	void Update() 
	{
		// Adds z position to score
		scoreText.text = player.position.z.ToString("0");
	}
}
