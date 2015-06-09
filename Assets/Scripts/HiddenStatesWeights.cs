using UnityEngine;
using System.Collections;

public class HiddenStatesWeights : MonoBehaviour {


	private Renderer Weight; 
	public GameObject CubeBelong; 
	public Color cubeColor; 
	// private Color clear = (0,0,0,0); 

//	public Color red = Color.red;
//	public Color yellow = Color.yellow; 

	// Use this for initialization
	void Start () {

		//cubeColor = Color.blue; 
		gameObject.GetComponent<Renderer> ().material.color = Color.clear;
		ColorChange (); 
		//Debug.Log ("Called Function");

	}

	void ColorChange(){
	
		if (cubeColor == Color.yellow)
		{
			gameObject.GetComponent<Renderer>().enabled=true;  
			gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
			//Debug.Log("Should Be YEEEEEEEEEELLLLOW");

		} 
		else if (cubeColor == Color.red)
		{
			//gameObject.SetActive(true);
			gameObject.GetComponent<Renderer>().enabled=true; 
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
			//Debug.Log("Should be REEEEEEEEEEEEEED");
		} 
		else 
		{	
			gameObject.GetComponent<Renderer>().enabled=false;  
			//gameObject.GetComponent<Renderer> ().material.color = Color.clear;
//			Debug.Log("Invisible");
			//gameObject.SetActive(false); 
		}

		//Debug.Log("Changed Color!!!!!!!!!!!!!!!! Or not...");
	
	}
	
	// Update is called once per frame
	void Update () {

		cubeColor = CubeBelong.GetComponent<Renderer> ().material.color; 
		ColorChange (); 
		//Debug.Log ("Update Called");
	
	}
}
