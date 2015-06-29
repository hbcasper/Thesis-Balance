using UnityEngine;
using System.Collections;

public class TransformParent : MonoBehaviour {

	
	public Transform newparent;
	


	public void Changeparentfull() {

			transform.parent = newparent.transform;
	}

	}
