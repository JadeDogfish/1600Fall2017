using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	// has inventory
	// has health (money)
	// interaction
	private GameObject ingredient;
	private Ingredients ingredientScript;
	public int Money = 20;
	public bool canScoop = false;

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Ingredients"){
			ingredientScript = collision.gameObject.GetComponent<Ingredients>();
			if(canScoop == true && Input.GetKeyDown(KeyCode.Space)){
					
			}
			}
		}
	
}
