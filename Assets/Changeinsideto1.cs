using UnityEngine;
using System.Collections;

public class Changeinsideto1 : MonoBehaviour {

	public Imused[] restartvar;
	
	// Use this for initialization
	public void Restartweights() {
		
		restartvar = gameObject.GetComponentsInChildren<Imused> ();
		foreach (Imused script in restartvar) {
			
			script.restart();
		}
	}
}
