using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Mammal {

	// Use this for initialization
	
	public override void Start () {
        base.Start();
        Bark();
    }
	void Bark () {
        print(this.name + " barks at the humans");
    }
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
