using UnityEngine;
using System.Collections;

public class CoroutineScript_02 : MonoBehaviour {
	public int number;
	public int maxNumber;

	public int ammo;

	void Start () {
		StartCoroutine(Health());
		StartCoroutine(AmmoLoad());
	}

	IEnumerator Health(){
		while(number<maxNumber){
			yield return new WaitForSeconds(2);
			print("Health at " + number);
			number ++;
		}

		/*print("First Action");
		yield return new WaitForSeconds(5);
		print("Second Action");*/
		
	}
	IEnumerator AmmoLoad(){
		while(ammo<15){
			yield return new WaitForSeconds(1);
			print("Ammo at " + ammo);
			ammo ++;
		}
	}
}
