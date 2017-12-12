﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
	// Controls the character
	public float speed = 10f;
	public float scoop = Input.GetAxis("Jump");
	float moveLeftRight = Input.GetAxis("Horizontal");
	float moveForwardBack = Input.GetAxis("Vertical");	
	// Use this for initialization
	void Start () {
		
		
	}
	void Update () {
			
		Vector3 move = new Vector3(moveLeftRight, 0f, moveForwardBack);
		transform.Translate(move * Time.deltaTime * speed);
	}
	
	}

