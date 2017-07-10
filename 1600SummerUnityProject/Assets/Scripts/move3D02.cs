using UnityEngine;
using System.Collections;

public class move3D02 : MonoBehaviour {

private Rigidbody myR;
public float myForce = 500;
public bool canJump;

void Start()
{
	myR = GetComponent<Rigidbody>();
}

// Update is called once per frame
	void FixedUpdate () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Jump();
		}
	}

	private void Jump()
	{
		myR.AddForce(0, myForce, 0);
	}
}
