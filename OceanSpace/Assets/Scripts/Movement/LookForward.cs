using UnityEngine;
using System.Collections;

public class LookForward : MonoBehaviour {

	public Transform sightStart, sightEnd;
	public bool vertical;
	public bool needsCollision = false;
	
	private bool collision = false;
	private bool collision2 = false;


	// Use this for initialization
	void Start () {
	
	}
	 
	// Update is called once per frame
	void Update () {
	
		collision = Physics2D.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer ("Solid"));

		if (this.tag == "Creature") { 
			collision2 = Physics2D.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer ("Submarine"));
		}

		Debug.DrawLine (sightStart.position, sightEnd.position, Color.green);

		if (collision) {
			this.transform.localScale = new Vector3 ((transform.localScale.x == 1) ? -1 : 1, 1, 1);

		} else if (collision2) {
			if (!vertical) {
				this.transform.localScale = new Vector3 ((transform.localScale.x == 1) ? -1 : 1, 1, 1);

			}
		}
	}
}
