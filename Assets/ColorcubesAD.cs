using UnityEngine;
using System.Collections;

public class ColorcubesAD : MonoBehaviour {


	public Seecubes[] activecubes;

	public void ActiveCubesAD() {

		activecubes = gameObject.GetComponentsInChildren<Seecubes> ();
		foreach (Seecubes script in activecubes) {
			
			script.ActiveCubesAD();
			script.DefineCubeColor();

		}
	}
}
