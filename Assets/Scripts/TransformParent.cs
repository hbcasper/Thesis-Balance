using UnityEngine;
using System.Collections;

public class TransformParent : MonoBehaviour {

	//public Transform initialParent;
	public Transform newparent;
	public Transform initialParent;
	private Imused isinside;


	// Use this for initialization
	void Start () {

		//transform.parent = initialParent;
		isinside = gameObject.GetComponent<Imused>();
				
}

	public void Changeparent() {
		if (isinside.Inside == 1) {
			transform.parent = newparent.transform;
		}
	}


	public void Restartparent(){

		transform.parent = initialParent.transform;

	}


	public void Changeparentfull() {

			transform.parent = newparent.transform;
	}

	}
