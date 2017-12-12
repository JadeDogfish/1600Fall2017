using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customers : MonoBehaviour {
	// randomly generates an order
	// doesn't work 100% of the time for some reason, don't know why
	// also probably longer than needed, but can't figure out a better way to do it
	public string[] iceCream = {"Cookies and Cream", "Vanilla", "Chocolate", "Mint", "Strawberry", "Chocolate and Vanilla Twist"};
	public string[] toppings = {"Chocolate Syrup", "Sprinkles", "A Banana"};
	public int[] orderNum = {1, 2, 3, 4, 5, 6};
	int choice1; int choice2; int choice3; int choice4; int choice5;
	string result1; string result2; string result3; string result4; int result5;
	
	
	// Use this for initialization
	void Start () {
		int choice1 = Random.Range(1,6);
		int choice2 = Random.Range(0,5);
		int choice3 = Random.Range(0,5);
		int choice4 = Random.Range(0,2);
		int choice5 = Random.Range(1,7);
		if(choice5 == 1){
			result5 = orderNum[0];
		}else if(choice5 == 2){
			result5 = orderNum[1];
		}else if(choice5 == 3){
			result5 = orderNum[2];
		}else if(choice5 == 4){
			result5 = orderNum[3];
		}else if(choice5 == 5){
			result5 = orderNum[4];
		}else if(choice5 == 6){
			result5 = orderNum[5];
		}
		if(choice1 == 1){
			result1 = iceCream[0];
		}else if(choice1 == 2){
			result1 = iceCream[1];
		}else if(choice1 == 3){
			result1 = iceCream[2];
		}else if(choice1 == 4){
			result1 = iceCream[3];
		}else if(choice1 == 5){
			result1 = iceCream[4];
		}else if(choice1 == 6){
			result1 = iceCream[5];
		}
		if(choice2 == 0){
			result2 = iceCream[0];
		}else if(choice2 == 1){
			result2 = iceCream[1];
		}else if(choice2 == 2){
			result2 = iceCream[2];
		}else if(choice2 == 3){
			result2 = iceCream[3];
		}else if(choice2 == 4){
			result2 = iceCream[4];
		}else if(choice2 == 5){
			result2 = iceCream[5];
		}
		if(choice3 == 0){
			result3 = iceCream[0];
		}else if(choice3 == 1){
			result3 = iceCream[1];
		}else if(choice3 == 2){
			result3 = iceCream[2];
		}else if(choice3 == 3){
			result3 = iceCream[3];
		}else if(choice3 == 4){
			result3 = iceCream[4];
		}else if(choice3 == 5){
			result3 = iceCream[5];
		}
		if(choice4 == 0){
			result4 = toppings[0];
		}else if(choice4 == 1){
			result4 = toppings[1];
		}else if(choice4 == 2){
			result4 = toppings[2];
		}
		CustomerOrders();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void CustomerOrders(){
		
		switch (orderNum[result5]){
			case 1:
				print("I'd like a single scoop of " + result1 + ", please.");
				break;
			case 2:
				print("I'd like a double scoop with " +result1+ " and " +result2+ " please.");
				break;
			case 3:
				print("I'd like a triple scoop with " +result1+ ", " +result2+ ", and " +result3+ " please.");
				break;
			case 4:
				print("I'd like a single scoop of " +result1+ " with " +result4+ " please.");
				break;
			case 5:
				print("I'd like a double scoop with " +result1+ " and " +result2+ " with " +result4+ " please." );
				break;
			case 6:
				print("I'd like a triple scoop with " +result1+ ", " +result2+ ", and " +result3+ " with " +result4+ " please.");
				break;
			case 7:
				print("MissingNo.");
				break;
			
			
		}
		{
			
		}
	}
}
