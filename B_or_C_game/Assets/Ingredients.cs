using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients : MonoBehaviour {
	// makes it possible to pick up anything
	public bool canScoop = false;
	
	void Update () {
		if(canScoop == true && Input.GetKeyDown(KeyCode.Space)){
			
		}
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			canScoop = true;
		}
	}
	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Player"){
			canScoop = false;
		}
	}
}
