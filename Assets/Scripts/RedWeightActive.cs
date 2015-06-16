using UnityEngine;
using System.Collections;

public class RedWeightActive : MonoBehaviour {

	
	//Sets the GameObjectActive only when the cube color is yellow 
	
	public GameObject CubeBelong; 
	public Color cubeColor; 
	// Seecubes otherScript = GetComponent<Seecubes>(); 
	
	// Use this for initialization
	void Start () {
		
		gameObject.GetComponent<Renderer>().enabled=false;
		//		gameObject.GetComponent<Renderer>().enabled=true; 
		//		cubeColor = CubeBelong.GetComponent<Renderer> ().material.color;
	}
	
	void SetActive2Cube(){
		
		if (cubeColor == Color.red)
		{
			gameObject.GetComponent<Renderer>().enabled=true;  
			//Debug.Log ("THIS IS YELLOW SO IM ACTIVE");
		} 
		
		else 
		{	
			gameObject.GetComponent<Renderer>().enabled=false;  
			//Debug.Log ("RED = NOTACTIVE");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		cubeColor = CubeBelong.GetComponent<Renderer> ().material.color;
		SetActive2Cube();
	}

}
