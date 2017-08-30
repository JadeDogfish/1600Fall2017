using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {

public override void Start() {
        base.Start();
        isWarm();
    }
	void isWarm () {
        print(this.name + " is likely cute");
    }
}
