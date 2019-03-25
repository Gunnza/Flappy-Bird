using UnityEngine;
using System.Collections;

//randomly spawn the different pipe positions
public class SpawnPipes : MonoBehaviour {
	
	//init variables
	public GameObject Pipes;
	Vector3 PipePosition;

	// Use this for initialization
	void Start () {
		
		//start the coroutine at initialization
		StartCoroutine(Spawning());
		
	}
	
	IEnumerator Spawning() {
		
		//wait 1.1 seconds
		yield return new WaitForSeconds(1.1f);
		
		//randomly select a pipe position and store it in a variable
		Vector3 PipePosition = new Vector3(6f, Random.Range(-10f,-2.5f), 6.01f);
		
		//spawn the new pipe in the stored pipe position
		Instantiate (Pipes,PipePosition,Quaternion.identity); 
		
		//repeat the coroutine
		Start ();
	
	}
}
