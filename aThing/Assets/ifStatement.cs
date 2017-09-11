using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {
	public Text input;
	public string password = "dog";

	void update(){
		if(input.text == password){
			print("Password Accepted.");
		}
	}
}
