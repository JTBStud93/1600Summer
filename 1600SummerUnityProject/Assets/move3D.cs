using UnityEngine;
using System.Collections;

public class move3D : MonoBehaviour {
	public float moveSpeed;
	public float turnSpeed;

	void Update() {
		var y = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;

		transform.Rotate(0,y,0);
		transform.Translate(0,0,z);
	}
}
