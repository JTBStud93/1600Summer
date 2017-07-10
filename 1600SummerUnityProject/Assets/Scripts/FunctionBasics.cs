using UnityEngine;
using System.Collections;

public class FunctionBasics : MonoBehaviour {

	void Start () {
		print("Start");
	}
	
	void Awake () 
	{
		print("Awake");
	}

	void OnEnable ()
	{
		print("Enabled");
	}

	void OnDisable ()
	{
		print("Disabled");
	}

	void OnTriggerEnter (Collider _col)
	{
		print(_col.name);
		if(_col.name != "enemy")
		{
			_col.gameObject.SetActive(false);
		}
		else
		{
			print("Adding Health");
		}
	}

	void OnTriggerExit ()
	{
		print("Exit");
	}

}
