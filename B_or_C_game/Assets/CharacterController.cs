﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
	// Controls the character, among other things
	public SphereCollider player;
	public float speed = 10f;
	private GameObject ingredient;
	private Ingredients ingredientScript;
	public int Money = 20;
	// Use this for initialization
	void Start () {
		player = this.GetComponent<SphereCollider>();
		
	}
	void Update () {
		float moveLeftRight = Input.GetAxis("Horizontal");
		float moveForwardBack = Input.GetAxis("Vertical");
		float scoop = Input.GetAxis("Jump");
		Vector3 move = new Vector3(moveLeftRight, 0f, moveForwardBack);
		transform.Translate(move * Time.deltaTime * speed);
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Ingredients"){
			ingredientScript = collision.gameObject.GetComponent<Ingredients>();
			
				
			}
		}
	}

