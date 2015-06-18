using UnityEngine;
using System.Collections;

public class ColorcubesAD : MonoBehaviour {


	public Seecubes[] activecubes;

	public void Start(){
		activecubes = gameObject.GetComponentsInChildren<Seecubes> ();
	}


	public void ActiveCubesAD() {
		
		foreach (Seecubes script in activecubes) {
			
			script.ActiveCubesAD ();


		}
	}

		public void DeactiveCubesAD() {
			
			activecubes = gameObject.GetComponentsInChildren<Seecubes> ();
			foreach (Seecubes script in activecubes) {
				
				script.NoActiveCubesAD();
				
				
			}
	}
}
