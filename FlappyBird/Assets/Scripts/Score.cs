using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	//init public score integer variable 
	public static int score = 0;

	// Update is called once per frame
	void Update () {
		
		//always show updated score variable (not the most efficient)
		guiText.text = score.ToString();
		
	}
}
