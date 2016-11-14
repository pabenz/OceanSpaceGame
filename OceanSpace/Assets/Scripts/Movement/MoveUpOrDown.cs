using UnityEngine;
using System.Collections;

public class MoveUpOrDown : MonoBehaviour {

	public float speed = 0.5f;
	public bool red;
	public bool green;
	public bool yellow;
	public bool blue;
	//public float speedMultiplier = Random.Range (0.25f, 12f);
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame 
	void Update () {
		if (red || green || blue || yellow) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, transform.localScale.y) * speed; 
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, transform.localScale.y) *  (Random.Range (.25f, 12f));
		}
	}
}
