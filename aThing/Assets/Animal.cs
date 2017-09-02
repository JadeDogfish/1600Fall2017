using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	public virtual void Start () {
		Die();
		Eat();
		Sleep();
	}

	void Die() {
		print(this.name + " dies eventually.");
	}
	void Eat() {
		print(this.name + " eats a TON of food.");
	}
	void Sleep() {
		print(this.name + " sleeps like a rock.");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
