using UnityEngine;
using System.Collections;

public class ColorcubesAD : MonoBehaviour {


	public Seecubes[] activecubes;

	public void ActiveCubesAD() {
		Debug.Log ("GotHere7");

		activecubes = gameObject.GetComponentsInChildren<Seecubes> ();
		foreach (Seecubes script in activecubes) {
			
			script.ActiveCubesAD();


		}
	}
}
