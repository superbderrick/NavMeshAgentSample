using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
	public Text scoreText;
	public int 	numberOfMushrooms = 8;

	AudioSource audioSource;
	float score = 0f;

	void Awake()
	{
		audioSource = GetComponent<AudioSource> ();

		if(scoreText != null)
			scoreText.text = "Mushrooms: " + score + " / " + numberOfMushrooms;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.CompareTag("Mushroom"))
		{
			audioSource.Play();
			Destroy (col.gameObject);	
			score++;

			if(scoreText != null)
				scoreText.text = "Mushrooms: " + score + " / " + numberOfMushrooms;
		}
	}
}