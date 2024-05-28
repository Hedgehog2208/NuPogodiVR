
using UnityEngine;

public class Egg : MonoBehaviour
{
    [SerializeField] private int scoreValue;
	[SerializeField] private int minusScoredValue;
	private ScoreCounter scoreCounter;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.GetComponent<Wolf>())
		{
			scoreCounter.AddScore(scoreValue);
			//DestroyObj();
		}
		if (collision.collider.GetComponent<Earth>())
		{
			scoreCounter.AddScore(minusScoredValue);
			//DestroyObj();
		}
	}

	public void SetScore(ScoreCounter scoreCounter)
	{
		this.scoreCounter = scoreCounter;
	}

	public void DestroyObj()
	{
		Destroy(gameObject);
	}
}
