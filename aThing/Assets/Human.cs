using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Mammal {

public override void Start() {
        base.Start();
        makesArt();
    }
	void makesArt () {
        print(this.name + " is an artist today");
    }
}
