using UnityEngine;
using System.Collections;
#if UNITY_5_5_OR_NEWER
using UnityEngine.SceneManagement;
#endif

public class Respawn : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.CompareTag( "Player"))
		{
			// ... reload the level.

			#if UNITY_5_5_OR_NEWER
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			#else
				Application.LoadLevel(Application.loadedLevel);
			#endif
		}
	}
}