using UnityEngine;
using System.Collections;

//attached to player
public class Hurt : MonoBehaviour {

	//we want bubbles to FadeOverTime here (BodyPart in tutorial)
	public FadeOverTime bubbles;
	public int totalBubbles = 5;

	private Animator animator;
    public bool isHurt;

	// Use this for initialization
	void Start () {
		isHurt = false;
	}
	
	// Update is called once per frame
	void Update () {
		isHurt = false;
	}

	void OnCollisionEnter2D(Collision2D target){
		
		if (target.gameObject.tag == "Deadly") {
			isHurt = true;
			OnHurt ();
		}
	}

	/// <summary>
	/// need to transition to hurt animation
	/// Wont reset?
	/// </summary>
	void OnHurt(){

		var t = transform;

		for (int i = 0; i < totalBubbles; i++) {
			t.TransformPoint (0, -100, 0);
			FadeOverTime clone = Instantiate (bubbles, t.position, Quaternion.identity) as FadeOverTime;
			//generate if go left or right
			clone.GetComponent<Rigidbody2D> ().AddForce (Vector3.right * Random.Range (-50, 50));
			//how high it goes
			clone.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * Random.Range (100, 400));


		}
	}

	void hurtDestroy(){
		Destroy (gameObject);
	}

}
