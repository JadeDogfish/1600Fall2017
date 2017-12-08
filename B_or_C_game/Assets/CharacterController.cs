using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
	// Controls the character
	public SphereCollider player;
	public float speed = 10f;
	
	// Use this for initialization
	void Start () {
		
		
	}
	void Update () {
		float moveLeftRight = Input.GetAxis("Horizontal");
		float moveForwardBack = Input.GetAxis("Vertical");
		float scoop = Input.GetAxis("Jump");
		Vector3 move = new Vector3(moveLeftRight, 0f, moveForwardBack);
		transform.Translate(move * Time.deltaTime * speed);
	}
	
	}

