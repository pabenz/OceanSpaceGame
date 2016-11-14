using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {

	public bool needsCollision = true;

	public bool movingUpDown;
	public bool movingLeftRight;

	private bool collision = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		
		if (movingUpDown) {
			this.transform.localScale = new Vector3 (1, (transform.localScale.y == 1) ? -1 : 1, 1);
		}	
		if (movingLeftRight) {
			this.transform.localScale = new Vector3 ((transform.localScale.x == 1) ? -1 : 1, 1, 1);
		}
	}
}
