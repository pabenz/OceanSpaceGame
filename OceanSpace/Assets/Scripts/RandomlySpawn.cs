using UnityEngine;
using System.Collections;

public class RandomlySpawn : MonoBehaviour {

	public int numToSpawn;
	public Vector3 position;
	public GameObject target; 

	// Use this for initialization
	void Start() 
	{
		int spawned = 0;
		
		while (spawned < numToSpawn)
		{
			position = new Vector3(Random.Range(10.0F, 10.0F), Random.Range(10.0F, 10.0F), -10);
			Instantiate(target, position, Quaternion.identity);
			spawned++;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
