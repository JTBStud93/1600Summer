using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player"){
			Destroy(gameObject);
		}
	}

}
