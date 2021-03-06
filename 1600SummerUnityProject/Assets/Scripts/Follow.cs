﻿using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public Transform theWolf;

	void Update () {

	}

	void OnTriggerStay(Collider other)
	{
	
		if(other.gameObject.name == "Player"){
					Debug.Log("Player has entered chicken's trigger");
					transform.LookAt(target);
					transform.Translate(Vector3.forward*-moveSpeed*Time.deltaTime);
		}

		if(other.gameObject.name =="Wolf"){
			Debug.Log("Wolf has entered chicken's trigger");
			transform.LookAt(theWolf);
			transform.Translate(Vector3.forward*-moveSpeed*Time.deltaTime);
		}
	}
}
