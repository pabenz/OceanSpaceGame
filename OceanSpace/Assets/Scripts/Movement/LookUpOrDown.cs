using UnityEngine;
using System.Collections;

public class LookUpOrDown : MonoBehaviour {

	public Transform sightStart, sightEnd;
	
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
		
		if (collision || collision2) {
			this.transform.localScale = new Vector3 (1, (transform.localScale.y == 1) ? -1 : 1, 1);
			
		}		
	}
}