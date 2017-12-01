using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customers : MonoBehaviour {
	
	public string[] iceCream = {"Cookies and Cream", "Vanilla", "Chocolate", "Mint", "Strawberry", "Chocolate-Vanilla Twist"};
	public string[] toppings = {"Chocolate Syrup", "Sprinkles", "A Banana"};
	int choice1 = Random.Range(0, 5);
	int choice2 = Random.Range(0, 5);
	int choice3 = Random.Range(0, 5);
	int choice4 = Random.Range(0, 2);
	int choice5 = Random.Range(0, 5);	
	string result1; string result2; string result3; string result4; int result5;
	
	// Use this for initialization
	void Start () {
		int choice1 = Random.Range(0, 5);
		int choice2 = Random.Range(0, 5);
		int choice3 = Random.Range(0, 5);
		int choice4 = Random.Range(0, 2);
		int choice5 = Random.Range(0, 5);
		int orderNum = choice5;
		CustomerOrders();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void CustomerOrderChoice(){
		//not sure how else to do it, really
		if(choice1 == 0){
			result1 = iceCream[0];
		}else if(choice1 == 1){
			result1 = iceCream[1];
		}else if(choice1 == 2){
			result1 = iceCream[2];
		}else if(choice1 == 3){
			result1 = iceCream[3];
		}else if(choice1 == 4){
			result1 = iceCream[4];
		}else if(choice1 == 5){
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
		
	}
	void CustomerOrders(){
		
		switch (orderNum[6]){
			case 0:
				CustomerOrderChoice();
				print("I'd like a single scoop of " + result1 + ", please.");
				break;
			case 1:
				CustomerOrderChoice();
				print("I'd like a double scoop with " +result1+ " and " +result2+ " please.");
				break;
			case 2:
				CustomerOrderChoice();
				print("I'd like a triple scoop with " +result1+ ", " +result2+ ", and " +result3+ " please.");
				break;
			case 3:
				CustomerOrderChoice();
				print("I'd like a single scoop of" +result1+ " with " +result4+ " please.");
				break;
			case 4:
				CustomerOrderChoice();
				print("I'd like a double scoop with " +result1+ " and " +result2+ " with " +result4+ " please." );
				break;
			case 5:
				CustomerOrderChoice();
				print("I'd like a triple scoop with " +result1+ ", " +result2+ ", and " +result3+ " with " +result4+ " please.");
				break;
			
		}
		{
			
		}
	}
}
