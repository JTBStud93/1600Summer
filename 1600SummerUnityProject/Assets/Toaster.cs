using UnityEngine;
using System.Collections;

public class Toaster : MonoBehaviour {
	public int num1;
	public int num2;

	void Start(){
		int num = AddNumbers(num1, num2);
		print(num);
	}
	
	public int AddNumbers(int number1, int number2){
		int result = number1 + number2;

		return result;
	}

}
