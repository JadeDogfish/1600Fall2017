using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal {
// Bird inherits from Animal which makes it susceptible to death
	public override void Start() {
        base.Start();
        Fly();
        // Bird is the only animal that flies
    }
	void Fly () {
        print(this.name + " flies");
        // This prints out "Bird flies"
    }
}
