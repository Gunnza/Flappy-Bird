using UnityEngine;
using System.Collections;

public class MovePipes : MonoBehaviour {
	
	float Movement;
	
	public static bool moving = true;


	// Use this for initialization
	void Start () {
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (moving == true)
			Movement = -.1f;
		
		if (moving == false)
			Movement = 0;
		
		transform.Translate(Movement,0,0);
	
	}
}
