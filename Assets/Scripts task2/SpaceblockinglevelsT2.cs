using UnityEngine;
using System.Collections;

public class SpaceblockinglevelsT2 : MonoBehaviour {

	// Use this for initialization

	public string desleftcube1;
	public string desleftcube2;
	public string desleftcube3;
	public string desrightcube1;
	public string desrightcube2;
	public string desrightcube3;
	public int lcubenumber1;
	public int lcubenumber2;
	public int lcubenumber3;
	public int rcubenumber1;
	public int rcubenumber2;
	public int rcubenumber3;

	void Start () {

	
	}
	void Update(){
		desleftcube1 = "LeftCube" + lcubenumber1;
		desleftcube2 = "LeftCube" + lcubenumber2;
		desleftcube3 = "LeftCube" + lcubenumber3;
		desrightcube1 = "RightCube" + rcubenumber1;
		desrightcube2 = "RightCube" + rcubenumber2;
		desrightcube3 = "RightCube" + rcubenumber3;
	}

	void restart(){
		lcubenumber1 = 0;
		lcubenumber2 = 0;
		lcubenumber3 = 0;
		rcubenumber1 = 0;
		rcubenumber2 = 0;
		rcubenumber3 = 0;
	}


	// Update is called once per frame
	public void level1(){
		restart ();
		lcubenumber1 = Random.Range (1, 7);
		rcubenumber1 = lcubenumber1;
	}
	public void level2(){
		restart ();
		lcubenumber1 = Random.Range (1, 7);
		lcubenumber2 = Random.Range (1, 7);
		while (lcubenumber2 == lcubenumber1) {
			lcubenumber2 = Random.Range (1, 7);
		}
		rcubenumber1 = Random.Range (1, 7);

		rcubenumber2 = Random.Range (1, 7);
		while (rcubenumber2 == rcubenumber1) {
			rcubenumber2 = Random.Range (1, 7);
		}

	}
	public void level3(){
		restart ();
		lcubenumber1 = Random.Range (1, 7);
		lcubenumber2 = Random.Range (1, 7);
		while (lcubenumber2 == lcubenumber1) {
			lcubenumber2 = Random.Range (1, 7);
		}
		rcubenumber1 = Random.Range (1, 7);
		while (rcubenumber1 == lcubenumber2 || rcubenumber1 == lcubenumber1) {
			rcubenumber1 = Random.Range (1, 7);
		}
		
		rcubenumber2 = Random.Range (1, 7);
		while (rcubenumber2 == rcubenumber1 || rcubenumber2 == lcubenumber1 || rcubenumber2 == lcubenumber2) {
			rcubenumber2 = Random.Range (1, 7);
		}
	}
	public void level4(){
		lcubenumber1 = Random.Range (1, 7);
		lcubenumber2 = Random.Range (1, 7);
		while (lcubenumber2 == lcubenumber1) {
			lcubenumber2 = Random.Range (1, 7);
		}
		lcubenumber3 = Random.Range (1, 7);
		while (lcubenumber3 == lcubenumber1 || lcubenumber3 == lcubenumber2) {
			lcubenumber3 = Random.Range (1, 7);
		}

		rcubenumber1 = Random.Range (1, 7);
		rcubenumber2 = Random.Range (1, 7);
		while (rcubenumber2 == rcubenumber1) {
			rcubenumber2 = Random.Range (1, 7);
		}
		rcubenumber3 = Random.Range (1, 7);
		while (rcubenumber3 == rcubenumber1 || rcubenumber3 == rcubenumber2) {
			rcubenumber3 = Random.Range (1, 7);
		}

	}


}
