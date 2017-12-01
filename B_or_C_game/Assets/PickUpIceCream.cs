using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpIceCream : MonoBehaviour {
	public string[] iceCream = {"Cookies and Cream", "Vanilla", "Chocolate", "Mint", "Strawberry", "Chocolate-Vanilla Twist"};
	public string[] toppings = {"Chocolate Syrup", "Sprinkles", "A Banana"};
	public string[] inventory = new string[9];
	public string inCone;
	// Use this for initialization
	void update (){
		for(int i = 1; i >= 0; i--){
			PickUp();
		}
		
	}
	public void PickUp () {
		//here's 2 switches; others are in Customers
		switch (iceCream[7]){
			case "Cookies and Cream":
				inventory[0] = "Cookies and Cream";
				break;
			case "Vanilla":
				inventory[1] = "Vanilla";
				break;
			case "Chocolate":
				inventory[2] = "Chocolate";
				break;
			case "Mint":
				inventory[3] = "Mint";
				break;
			case "Strawberry":
				inventory[4] = "Strawberry";
				break;
			case "Chocolate-Vanilla Twist":
				inventory[5] = "Chocolate-Vanilla Twist";
				break;
			case null:
				print("You didn't scoop any ice cream.");
				break;
		}
		switch (toppings[4]){
			case "Chocolate Syrup":
				inventory[6] = "Chocolate Syrup";
				break;
			case "Sprinkles":
				inventory[7] = "Sprinkles";
				break;
			case "A Banana":
				inventory[8] = "A Banana";
				break;
			case null:
				print("You didn't apply any toppings.");
				break;
			}

		}	
}
