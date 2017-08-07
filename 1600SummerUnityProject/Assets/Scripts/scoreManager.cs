using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour {

	public static int score;
	public int winScore;

	public Text text;

	void Start (){
		text = GetComponent<Text>();
			score = 0;
	}

	void Update (){
		if(score < 0)
			score = 0;

		text.text =" " + score;

		if(score >= winScore){
			SceneManager.LoadScene("WinScene");
			print("You Win!");
		}

	}

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}

	public void Reset(){
		score = 0;
	}

}
