using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
	public SphereCollider player;
	public float speed = 15f;
	private GameObject ingredient;
	private Ingredients ingredientScript;
	public int Money = 20;
	// Use this for initialization
	void Start () {
		player = this.GetComponent<SphereCollider>();
		ingredient = GameObject.Find("Cookies and Cream");
		ingredientScript = ingredient.GetComponent<Ingredients>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveLeftRight = Input.GetAxis("Horizontal");
		float moveForwardBack = Input.GetAxis("Vertical");
		float scoop = Input.GetAxis("Jump");
		Vector3 move = new Vector3(moveLeftRight, 0f, moveForwardBack);
		transform.Translate(move * Time.deltaTime * speed);
		if(Input.GetKeyDown(KeyCode.Space)){
			scoop = 1;
		}

	}
}
