using UnityEngine;
using System.Collections;

//if the player collides with pipes play the gameover screen
public class HitPipes : MonoBehaviour {
	
	//init variables
	public GameObject bird;
	public GameObject Retry;
	
	void Start()  {
		
		Score.score = 1; //set score to 1 from the score script  
		MovePipes.moving = true; //set the move pipes to true from the MovePipes script
		Retry.SetActive(false); //deactivating the retry button
		
	}

	
	void OnTriggerEnter(Collider col) {
		
		//if player collides with the pipe player will fall to the ground
		if(col.gameObject.tag == "Pipe")
		{
			//stop the illusion of the player moving by stopping the pipes
			MovePipes.moving = false;
			
			//disable jump features 
			bird.GetComponent<Jump>().enabled = false;	
		}
	
		//if player touches ground they die
		if(col.gameObject.tag == "Ground")	
		{
			//stop time in the game 
			Time.timeScale = 0;
			
			//activate the retry button
			Retry.SetActive(true);	
		}
		
		//if the player gets through an obstacle add 1 to the score 
		if(col.gameObject.tag == "HitPoint")	
		{
			Score.score +=1;
		}
		
		
	}
	
}
	

