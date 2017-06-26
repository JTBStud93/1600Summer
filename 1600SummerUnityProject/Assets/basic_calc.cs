using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class basic_calc : MonoBehaviour {

 public InputField in1;
 public InputField in2;
 public Text result;

public void AddClick(){
	int num = int.Parse(in1.text) + int.Parse(in2.text);
	result.text = num.ToString();
}






	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
