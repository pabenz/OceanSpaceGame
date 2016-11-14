using UnityEngine;
using System.Collections;

public class Air : MonoBehaviour {

	public float air = 100;
	public float maxAir = 100;
	public float airBurnRate = 1f;
	public float damageAirLoss = 5;

	private Hurt hurty;

	public Texture2D bgTexture;
	public Texture2D airBarTexture;

	public FadeOverTime bubbles;
	public int totalBubbles = 5;
	public int iconWidth = 64;
	public Vector2 airOffSet = new Vector2(100,100);


	// Use this for initialization
	void Start () {
	

		///player = GameObject.FindObjectOfType<Player>();

	}

	void OnGUI(){

		var percent = Mathf.Clamp01 (air / maxAir);

		DrawMeter (airOffSet.x, airOffSet.y, airBarTexture, bgTexture, percent);

	}

	void DrawMeter(float x, float y, Texture2D texture, Texture2D background, float percent){

		var bgW = background.width;
		var bgH = background.height;

		GUI.DrawTexture (new Rect (x, y, bgW, bgH), background);

		var nW = ((bgW - iconWidth) * percent) + iconWidth;
		GUI.BeginGroup (new Rect (x, y, nW, bgH));
		GUI.DrawTexture (new Rect (0, 0, nW, bgH), texture);

		GUI.EndGroup ();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (air > 0) {
			air -= Time.deltaTime * airBurnRate;

		} else {
			Destroy(gameObject);

			var percent = 0;

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
	}
}
