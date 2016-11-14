using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speedSide = 5f;
	//public float speedUp = 3f;
	public float speedDown = 6f;
	public float upSpeedMultiplier = .25f;
	public Vector2 maxVelocity = new Vector2(5, 7);

 	public static int collectedB;
    public static int collectedY;

	
	private Animator animator;
	private PlayerController controller;
	private Hurt hurt;
	private bool isHurt;

	// Use this for initialization
	void Start () {

		controller = GetComponent<PlayerController> ();
		animator = GetComponent<Animator> ();
		hurt = GetComponent<Hurt> ();

		collectedB = 0;
		collectedY = 0;


		
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Blue") {
			collectedB++;
			Destroy(target);
		}
		if (target.tag == "Yellow") {
			collectedY++;
			Destroy(target);
		}
	}

	public int GetCollectedB(){
		return collectedB;
	}

	public int GetCollectedY(){
		return collectedY;
	}

	// Update is called once per frame
	void Update () {
	
		var forceX = 0f;
		var forceY = 0f;

		var absValX = Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x);
		var absValY = Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y);

		if (controller.moving.x != 0) {

			if(absValX < maxVelocity.x){
				forceX = speedSide * controller.moving.x;

				transform.localScale = new Vector3(forceX > 0 ? 1 : -1, 1, 1);
			}
		}

		if (controller.moving.y > 0) {
			
			if(absValY < maxVelocity.y){
				forceY = speedDown * controller.moving.y * upSpeedMultiplier;
			}
		}

		if (controller.moving.y < 0) {
			
			if(absValY < maxVelocity.y){
				forceY = speedDown * controller.moving.y;
			}
		}

		if (hurt.isHurt) {
			animator.SetInteger ("AnimState", 1);
		} else {
			animator.SetInteger ("AnimState", 0);
		}

		GetComponent<Rigidbody2D>().AddForce(new Vector2(forceX, forceY));
	}
}
