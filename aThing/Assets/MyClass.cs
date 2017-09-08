﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass : MonoBehaviour {

	// Conventions and Syntax is all about writing out your code so the computer can understand it.
	// A few examples:
	// Two forward slashes mean the computer will gloss over the line; these are comments for humans.
	// Curly brackets are for opening and closing the body of things like that "void Start ()".
	// Most everything needs to be opened and closed or the computer won't know what's going on.
	// Like " ", and ().
	// Another thing the computer needs: a semicolon. This denotes the end of a line of code. 
	// An "=" will tell the computer that an identifier refers to whatever you put on the other side,
	// Like a number or a string. I put a couple integers on line 17.
	// Then in "Start ()" I had the computer add the two and print the result.
	// The "()" are for parameters. It tells the computer what exactly to do with a particular command.
	// Like with print(), which will simply print what you put in the "()".
	// Quotes are basically telling the computer that the contents are not code, but a string. 
	string myString = "Hello";
	int x = 2; int y = 3;
	void Start () {
		print(myString);
		print(x + y);
	}
	
	
}
