using UnityEngine;
using System.Collections;

public class Changeinsideto1 : MonoBehaviour {

	private Imused[] restartvar;
	private Returnoriginalposition[] originalpositionscript;

	
	// Use this for initialization
	public void Restartweights() {
		
		restartvar = gameObject.GetComponentsInChildren<Imused> ();
		foreach (Imused script in restartvar) {
			
			script.restart ();
		}
	}

	public void ReturnOriginalPosition(){

			originalpositionscript = gameObject.GetComponentsInChildren<Returnoriginalposition> ();
			foreach (Returnoriginalposition script in originalpositionscript){

				script.ReturnOriginalPosition();

			}
	
	
	}
}
