using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public Transform spawnPoint;
	public int points;

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player"){
			//Destroy(gameObject);
			scoreManager.AddPoints(points);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
		}

		if(other.gameObject.name == "Wolf"){
			//Destroy(gameObject);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
		}
	}

}
