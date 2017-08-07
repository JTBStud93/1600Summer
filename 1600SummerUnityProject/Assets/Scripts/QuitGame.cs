using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour {
	
	public void GameOver () {
		Application.Quit();
	}
}
