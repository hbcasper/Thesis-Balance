using UnityEngine;
using System.Collections;

public class Checkcorrect : MonoBehaviour {

	private Receivedweight Colorofweight;
	private Imcolor Colorofcube;
	public string result = "Incorrect";

	void Start () {

		Colorofweight = gameObject.GetComponent<Receivedweight> ();
		Colorofcube = gameObject.GetComponent<Imcolor> ();
	}


	void Update () {

		if (Colorofweight.Cubereceives == Colorofcube.Cubecolor)
			{
			result = "correct";
			}
		else
		{
			result = "incorrect";
		}
	
	}
}
