using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	public static int score = 0;

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		
		guiText.text = score.ToString();
	
	}
}
