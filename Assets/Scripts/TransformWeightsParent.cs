﻿using UnityEngine;
using System.Collections;

public class TransformWeightsParent : MonoBehaviour {

	public Transform initialParent;
	public Transform newparent;
	private Imused isinside;


	// Use this for initialization
	void Start () {

		transform.parent = initialParent;
		isinside = gameObject.GetComponent<Imused>();

			
}

	public void Changeparent() {


	
		if (isinside.Inside == 1) {
			Debug.Log ("correctisimo");
			transform.parent = newparent.transform;
		}
	}

	}
