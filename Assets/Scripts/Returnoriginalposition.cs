using UnityEngine;
using System.Collections;

public class Returnoriginalposition : MonoBehaviour {

	Vector3 originalPosition;

	public void Start(){

		originalPosition = gameObject.transform.position;
	}


	
	// Update is called once per frame
	public void ReturnOriginalPosition () {

		gameObject.transform.position = originalPosition;
	
	}
}
