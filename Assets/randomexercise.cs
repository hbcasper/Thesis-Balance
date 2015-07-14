using UnityEngine;
using System.Collections;
using System.Text;
using System;
using UnityEngine.UI;

public class randomexercise : MonoBehaviour {

	public string exercise;
	public string input = "12345";



	// Use this for initialization

	void Start(){
	
	}

	public void chooseexercise(){

		if (gameObject.GetComponent<checkifcorrect>().trials < 4) {
	
			exercise = excercisenumber ();
		}



	}


	public string excercisenumber () {


		StringBuilder activecubes = new StringBuilder();
		char ch;
		for (int i = 0; i < 1; i++)
		{
			
			ch = input[UnityEngine.Random.Range(0, input.Length-1)];
			activecubes.Append(ch);
			input = input.Replace(ch.ToString(),string.Empty);
			
		}




		return activecubes.ToString();
	
	}
	

}
