using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public Transform spawnPoint;

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player"){
			//Destroy(gameObject);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
		}
	}

}
