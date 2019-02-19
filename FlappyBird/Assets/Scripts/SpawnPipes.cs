using UnityEngine;
using System.Collections;

public class SpawnPipes : MonoBehaviour {
	
	public GameObject Pipes;
	Vector3 PipePosition;

	// Use this for initialization
	void Start () {
		
		StartCoroutine(Spawning());
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
	
	}
	
	IEnumerator Spawning()
		
	{
		yield return new WaitForSeconds(1.1f);
		
		Vector3 PipePosition = new Vector3(6f, Random.Range(-10f,-2.5f), 6.01f);
		
		Instantiate (Pipes,PipePosition,Quaternion.identity); 
		
		Start ();
		
	}
}
