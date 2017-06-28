using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class basic_calc : MonoBehaviour {

 public InputField in1;
 public InputField in2;
	
/*
 public InputField in3;
 public InputField in4;
 public InputField in5;
 public InputField in6;
 public InputField in7;
 public InputField in8;
*/
	
 public Text result;

public void AddClick(){
	int num = int.Parse(in1.text) + int.Parse(in2.text);
	result.text = num.ToString();
}

/*
public void SubtractClick(){
	int num = int.Parse(in3.text) - int.Parse(in4.text);
	result.text = num.ToString();
}

public void MultiplyClick(){
	int num = int.Parse(in5.text) * int.Parse(in6.text);
	result.text = num.ToString();
}

public void DivideClick(){
	int num = int.Parse(in7.text) / int.Parse(in8.text);
	result.text = num.ToString();
}
*/




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
