using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public float speed = 0.5f;
	public bool red;
	public bool green;
	public bool yellow;
	public bool blue;
	//public float speedMultiplier = ;

	// Use this for initialization
	void Start () {
	
	} 
	
	// Update is called once per frame
	void Update () {
		if (red || green || blue || yellow) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (transform.localScale.x, 0) * speed; 
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (transform.localScale.x, 0) * (Random.Range (.25f, 12f));
		}
	}
}
