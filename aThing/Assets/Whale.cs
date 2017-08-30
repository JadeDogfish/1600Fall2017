using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : Mammal {

public override void Start() {
        base.Start();
        isBig();
    }
	void isBig () {
        print(this.name + " is very big");
    }
}
