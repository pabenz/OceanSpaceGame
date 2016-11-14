using UnityEngine;
using System.Collections;

public class LevelManagerO : MonoBehaviour {


	// Use this for initialization
	public void loadFinal(){
		Application.LoadLevel ("Final");
	}

	public void conditionalEncyclopedia(){

		if (Player.collectedB == 0) {
			Application.LoadLevel ("Border");
		}
		if (Player.collectedB == 1) {
			Application.LoadLevel ("Blue1");
		}
		if (Player.collectedB == 2) {
			Application.LoadLevel ("Blue2");
		}
		if (Player.collectedB == 3) {
			Application.LoadLevel ("Blue3");
		}
		if (Player.collectedB == 4) {
			Application.LoadLevel ("Blue4");
		}
		if (Player.collectedB == 5) {
			Application.LoadLevel ("Blue5");
		}
		if (Player.collectedB == 6) {
			Application.LoadLevel ("Blue6");
		}
		if (Player.collectedB == 7) {
			Application.LoadLevel ("Blue7");
		}
		if (Player.collectedB == 8) {
			Application.LoadLevel ("Blue8");
		}
		if (Player.collectedB == 9) {
			Application.LoadLevel ("Blue9");
		}
		if (Player.collectedB == 10) {
			Application.LoadLevel ("Blue10");
		}
		if (Player.collectedB == 11) {
			Application.LoadLevel ("Blue11");
		}
		if (Player.collectedB == 12) {
			Application.LoadLevel ("Blue12");
		}
		if (Player.collectedB == 13) {
			Application.LoadLevel ("Blue13");
		}
	}
	public void loadTotalLevel () {
		Application.LoadLevel ("Blue13");
	}

	public void loadFish1 () {
		Application.LoadLevel ("Fish1");
	}
	public void loadFish2 () {
		Application.LoadLevel ("Fish2");
	}
	public void loadFish3 () {
		Application.LoadLevel ("Fish3");
	}
	public void loadFish4 () {
		Application.LoadLevel ("Fish4");
	}
	public void loadFish5 () {
		Application.LoadLevel ("Fish5");
	}
	public void loadFish6 () {
		Application.LoadLevel ("Fish6");
	}
	public void loadFish7 () {
		Application.LoadLevel ("Fish7");
	}
	public void loadFish8 () {
		Application.LoadLevel ("Fish8");
	}
	public void loadFish9 ()  {
		Application.LoadLevel ("Fish9");
	}
	public void loadFish10 ()  {
		Application.LoadLevel ("Fish10");
	}
	public void loadFish11 () {
		Application.LoadLevel ("Fish11");
	}
	public void loadFish12 () {
		Application.LoadLevel ("Fish12");
	}
	public void loadFish13 () {
		Application.LoadLevel ("Fish13");
	}
}
