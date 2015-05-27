using UnityEngine;
using System.Collections;

public class Imcolor : MonoBehaviour {


	public string Cubecolor = "Grey";


	// Use this for initialization
	void Start () {

	
		//LOl
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(gameObject.GetComponent<Renderer> ().material.color == Color.red)
			{

			Cubecolor = "Red";

			}
		else if(gameObject.GetComponent<Renderer> ().material.color == Color.yellow)
			{

			Cubecolor = "Yellow";

			}
	}
}
