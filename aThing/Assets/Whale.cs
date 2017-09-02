using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : Mammal {
// Classes are basically categories within categories.
public override void Start() {
        base.Start();
        isBig();
        // When a class inherits from another class, it uses its parents code
        // along with its own.
    }
	void isBig () {
        print(this.name + " is very big");
        // Classes are generally used for having different pieces of code
        // be able to do some of the same things, so you don't have to copy
        // the same lines of code each time.
    }
}
