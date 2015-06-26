using UnityEngine;
using System.Collections;

public class Registeractivecubes : MonoBehaviour {

	Seecubes[] Cubes;
	public string activecubes;
	string leftred = "0";
	string leftyellow = "0";
	string rightred = "0";
	string rightyellow = "0";



	// Use this for initialization
	void Start () {
		Cubes = gameObject.GetComponentsInChildren<Seecubes>();
	
	}
	
	// Update is called once per frame
	void Update () {

		foreach (Seecubes script in Cubes) {

			if (script.cubeIsActive == true) {
				if(script.gameObject.tag == "Left"){

					if (script.colorName == "red"){
						leftred = script.cubeIndex.ToString();
				}
					if (script.colorName == "yellow"){
						leftyellow = script.cubeIndex.ToString();
				}
			}
				if(script.gameObject.tag == "Right"){
					
					if (script.colorName == "red"){
						rightred = script.cubeIndex.ToString();
					}
					if (script.colorName == "yellow"){
						rightyellow = script.cubeIndex.ToString();
					}
				}
			
			}

		
		}

		activecubes = (leftred+","+leftyellow+","+rightred+","+rightyellow);
		Debug.Log (activecubes);
	
	}
}
