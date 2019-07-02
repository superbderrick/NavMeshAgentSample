using UnityEngine;

public class FlipIt : MonoBehaviour
{
	public void Flip()
	{
		transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}
}
