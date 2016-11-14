using UnityEngine;
using System.Collections;

public class LevelManagerS : MonoBehaviour {
	
	// Use this for initialization
	public void loadFinal(){
		Application.LoadLevel ("Final");
	}
	
	public void conditionalEncyclopedia(){

		if (Player.collectedY == 0) {
			Application.LoadLevel ("Border");
		}
		if (Player.collectedY == 1) {
			Application.LoadLevel ("Yellow1");
		}
		if (Player.collectedY == 2) {
			Application.LoadLevel ("Yellow2");
		}
		if (Player.collectedY == 3) {
			Application.LoadLevel ("Yellow3");
		}
		if (Player.collectedY == 4) {
			Application.LoadLevel ("Yellow4");
		}
		if (Player.collectedY == 5) {
			Application.LoadLevel ("Yellow5");
		}
		if (Player.collectedY == 6) {
			Application.LoadLevel ("Yellow6");
		}
		if (Player.collectedY == 7) {
			Application.LoadLevel ("Yellow7");
		}
		if (Player.collectedY == 8) {
			Application.LoadLevel ("Yellow8");
		}
		if (Player.collectedY == 9) {
			Application.LoadLevel ("Yellow9");
		}

	}

	public void loadTotalLevel () {
		Application.LoadLevel ("Yellow9");
	}

	public void loadSpace1 () {
		Application.LoadLevel ("Space1");
	}
	public void loadSpace2 () {
		Application.LoadLevel ("Space2");
	}
	public void loadSpace3 () {
		Application.LoadLevel ("Space3");
	}
	public void loadSpace4 () {
		Application.LoadLevel ("Space4");
	}
	public void loadSpace5 () {
		Application.LoadLevel ("Space5");
	}
	public void loadSpace6 () {
		Application.LoadLevel ("Space6");
	}
	public void loadSpace7 () {
		Application.LoadLevel ("Space7");
	}
	public void loadSpace8 () {
		Application.LoadLevel ("Space8");
	}
	public void loadSpace9 ()  {
		Application.LoadLevel ("Space9");
	}

}
