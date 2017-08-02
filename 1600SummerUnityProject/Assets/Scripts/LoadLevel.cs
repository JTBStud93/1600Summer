using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {
	
	public void StartGame () {
		SceneManager.LoadScene("funfunfun");
	}
}
