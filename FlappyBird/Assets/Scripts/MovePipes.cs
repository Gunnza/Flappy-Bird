using UnityEngine;
using System.Collections;

//Give the illussion of the player moving forward by moving the pipes to the left
public class MovePipes : MonoBehaviour {
	
	//init variable for movement
	float Movement;
	
	//boolean to see if pipes are moving
	public static bool moving = true;

	// Update is called once per frame
	void Update () {
		
		//if moving is true set move varibale to moving backwards
		if (moving == true)
			Movement = -.1f; 
		
		//if moving is false stop the pipes from moving 
		if (moving == false)
			Movement = 0;
		
		//always be transforming the pipes based on the x y z variables 
		transform.Translate(Movement,0,0);
	
	}
}
