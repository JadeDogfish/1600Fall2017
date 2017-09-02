﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	public virtual void Start () {
		Die();
		Eat();
		Sleep();
	}

	void Die() {
		print(this.name + " dies");
	}
	void Eat() {
		print(this.name + " eats");
	}
	void Sleep() {
		print(this.name + " sleeps");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
