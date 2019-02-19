using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	
	float maxSpeed = 10f;
	bool clicked = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
						
	  foreach (Touch touch in Input.touches)
	{
			
	if (clicked == false)
	{
		if (touch.phase == TouchPhase.Began)
		{
				rigidbody.AddForce(0,1000,0);
				clicked = true; 			
		}			
	 }
				
		if (touch.phase == TouchPhase.Ended)
		{
			clicked = false;
		}
	}
		
}
			
	
	void FixedUpdate() {
			
		
		if (rigidbody.velocity.magnitude > maxSpeed)	
		{
			 rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
		}
			
	}
		
		
		
}
	

