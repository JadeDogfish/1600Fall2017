using System.Collections;
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
	double num1 = 3.2; double num2 = 9.5;
	char letter = 'a';
	float num3 = 100f;
	bool switch1 = true;
	void Start () {
		print(myString);
		print(x + y);

		print(num1 - num2);
		print(--num3);
		print(++num2);
		
		if(num1 <= 3.2){
			print("true.");
		}
		if(num1 > x){
			print("false.");
		}
		if(num2 >= 10.5){
			print("true.");
		}
		if(switch1 == true){
			print(num1 / num3);
			print(num2 * num1);
			

		}else{
			print(letter);

	}
	
	// Now I'm gonna talk about variables. I've used two already: "int" and "string".
	// int is short for integer, which is used for whole numbers.
	// string is for sets of words, like sentances or phrases.
	// char means character, meaning a single character, like: char letter = 'a';
	// double is for numbers with decimals.
	// float is for decimals too, but it doesn't store as many decimal places as double.
	
	// All the way down here is stuff about math operators.
	// ++variable adds one to the variable like on line 33.
	// --variable takes one away, like on line 32.
	// Then there's addition on line 30.
	// Subtraction on line 32.
	// A comparison, less than or equal to, on line 36.
	// Another, more than, on line 39.
	// Another, more than or equal to, on line 42.
	// Another, equal to, on line 45.
	// Division on line 46.
	// multiplication on line 47.
	
}
}
