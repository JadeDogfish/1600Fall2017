using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogs : MonoBehaviour {
	// Hi. I wrote this whole program, pretty much. I think I understand If-statements. There's a bunch of 'em here.
	// Basically, you're just meant to choose which dogs to pet while you're in Unity, and the program tells you the results.
	private string[] dogNames = new string[3] {"Bulldog","Cat","Beagle"};
	public float asYouWalk = 1000f;
	public bool petBullDog = false;
	public bool petSmallDog = false;
	public bool petBeagle = false;
	public bool doYouOwnADog = false;
	public string favorite;
	

	void Update () {
			
			}
	void Start () {
		print("You are walking down your street and there happens to be a few dogs.");
		for(asYouWalk = 1000f ; asYouWalk > 0 ; asYouWalk -= 1f){
			if(asYouWalk == 999f && petBullDog == true){
				print("The dog nearest you is a Bulldog. He is very cute. You give him a pat and his owner says his name is Charles.");
				favorite = dogNames[0];}

			if(asYouWalk == 700f && petSmallDog == true){
				print("This isn't actually a dog, now that you're up close. It's a cat.");
				print("Unfortunately, it just runs off when it sees you.");
				favorite = dogNames[1];}	
			
			if(asYouWalk == 300f && petBeagle == true){
				print("It's a Beagle! You pet the Beagle.");
				favorite = dogNames[2];}
	
			}
			if(asYouWalk == 0){
			if(favorite == dogNames[0]){
				print("You think you like Bulldogs more than you used to, after seeing Charles.");
			}	
			if(favorite == dogNames[1]){
				print("You kind of wish you'd gotten a chance to pet that cat.");
			}
			if(favorite == dogNames[2]){
				print("You've always liked Beagles.");
			}	
			if(asYouWalk == 0f){
				print("You've arrived at home.");
			}
			if(doYouOwnADog == true){
				print("Your Dog is so happy to see you! You pet it.");
			}
			
			}
	}
	
	
		
	

	

	
	}