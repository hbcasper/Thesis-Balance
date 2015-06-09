using UnityEngine;
using System.Collections;

public class TwoWeights : MonoBehaviour {


	//Sets the GameObjectActive only when the cube color is yellow 

	public GameObject CubeBelong; 
	public Color colorOfCube; 
	// Seecubes otherScript = GetComponent<Seecubes>(); 

	// Use this for initialization
	void Start () {
		colorOfCube = CubeBelong.GetComponent<Renderer> ().material.color;
		SetActive2Cube (); 
		Debug.Log (colorOfCube.ToString ());
	}

	void SetActive2Cube(){

		if (colorOfCube == Color.yellow) {
			gameObject.SetActive(true); 
			Debug.Log ("Should be active"); 
		}
	}
	
	// Update is called once per frame
	void Update () {
		colorOfCube = CubeBelong.GetComponent<Renderer> ().material.color;
		SetActive2Cube();
	}
}
