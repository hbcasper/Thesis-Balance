using UnityEngine;
using System.Collections;

public class changeimage : MonoBehaviour {

	GameObject exercisemanager;
	randomexercise exercisenumber;

	// Use this for initialization

	void Start(){
		exercisemanager = GameObject.Find ("testmanager");
		exercisenumber = exercisemanager.GetComponent<randomexercise> ();
	}



	public void image(){

			GetComponent<Renderer>().material.mainTexture = Resources.Load("Pre"+exercisenumber.exercise) as Texture;  
	}
}
