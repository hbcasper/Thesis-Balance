using UnityEngine;
using System.Collections;

public class Changechildrenparents : MonoBehaviour {

	TransformParent[] newParent;

	void Start(){
		newParent = gameObject.GetComponentsInChildren<TransformParent> ();
	}

	public void moveweights() {

		foreach (TransformParent script in newParent) {

			script.Changeparent ();
		}
	}

	public void restartparent() {
	
			foreach (TransformParent script in newParent) {
				
				script.Restartparent();
			}

	


	}
	


}
