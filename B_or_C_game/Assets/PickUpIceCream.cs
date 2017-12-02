using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpIceCream : MonoBehaviour {
	public string[] iceCream = {"Cookies and Cream", "Vanilla", "Chocolate", "Mint", "Strawberry", "Chocolate and Vanilla Twist"};
	public string[] toppings = {"Chocolate Syrup", "Sprinkles", "A Banana"};
	public string[] inventory = new string[9];
	public string inCone;
	// Use this for initialization
	void update (){
		if(scoop = 1){

		}
		
	}
	public void PickUp () {
		
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
			case "Chocolate and Vanilla Twist":
				inventory[5] = "Chocolate and Vanilla Twist";
				break;
			case null:
				print("You didn't scoop any ice cream. ");
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
