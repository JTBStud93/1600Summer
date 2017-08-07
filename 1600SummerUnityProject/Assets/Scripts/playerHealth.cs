using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

	public const int maxHealth = 100;
	public int currentHealth =maxHealth;
	//public Transform spawnPoint;

	public Text hp;
	public Text maxHP;

	void Update()
	{
		hp.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();
	}

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		if(currentHealth <= 0)
		{
			currentHealth=0;
			print("You're Dead! Game Over!");
			SceneManager.LoadScene("LoseScene");
			/*transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;*/

		}
	}

}
