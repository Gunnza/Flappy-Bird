using UnityEngine;
using System.Collections;

//Tap the screen to jump
public class Jump : MonoBehaviour {

//init max speed variable 	
float maxSpeed = 10f;
	
//init clicked boolen variable	
bool clicked = false;

// Update is called once per frame
void Update () {
	
	//each time the player touches the screen
	foreach (Touch touch in Input.touches) {
		
		//if not already clicked 
		if (clicked == false) 
		{
			//if the touch begins on the screen
			if (touch.phase == TouchPhase.Began)
			{
				//add force to the y axis of the player object
				rigidbody.AddForce(0,1000,0);
				
				//set clicked to true
				clicked = true; 			
			}			
		 }

		//once finger has left the screen
		if (touch.phase == TouchPhase.Ended)
		{
			//cliked is false so user can then jump again
			clicked = false;
		}
	}		
}
			
	
void FixedUpdate() {
	
	//if the player object goes faster than the max speed variable 
	if (rigidbody.velocity.magnitude > maxSpeed)	
		{
			//set the velocity to the maxspeed 
			 rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
		}		
	}						
}
	

