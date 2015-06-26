using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CorrectorIncorrect : MonoBehaviour {

	private Animate Result;
	GameObject Scale;
	Text Resulttext;

	// Use this for initialization
	void Start () {
		Scale = GameObject.Find ("Scale");
		Result = Scale.GetComponent<Animate> ();
		Resulttext = GetComponent<Text> ();

		Result = Scale.GetComponent<Animate> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Result.correct == 0)
		{ 
			Resulttext.color = Color.red; 
			Resulttext.text = "Incorrect";
		}
		
		if (Result.correct == 1)
		{
			Resulttext.color = Color.green; 
			Resulttext.text = "Correct";
		}
	
	}
}
