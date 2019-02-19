using UnityEngine;
using System.Collections;

public class HitPipes : MonoBehaviour {
	
	public GameObject bird;
	public GameObject Retry;
	
	void Start()
		
	{
		Score.score = 1;
		MovePipes.moving = true;
		Retry.SetActive(false);
	}

	
	void OnTriggerEnter(Collider col)	
	{
		if(col.gameObject.tag == "Pipe")
		{
			Debug.Log ("hit pipe");
			
			MovePipes.moving = false;
			bird.GetComponent<Jump>().enabled = false;	
		}
	

		if(col.gameObject.tag == "Ground")	
		{
			Time.timeScale = 0;
			Retry.SetActive(true);
			
			
		}
		
		if(col.gameObject.tag == "HitPoint")	
		{
			Score.score +=1;
		}
		
		
	}
	
}
	

