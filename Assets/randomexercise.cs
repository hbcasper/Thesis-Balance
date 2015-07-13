using UnityEngine;
using System.Collections;
using System.Text;
using System;
using UnityEngine.UI;

public class randomexercise : MonoBehaviour {

	public string exercise;
	string input = "12345";
	public int trials;


	// Use this for initialization

	void Start(){
		trials = 1;
	}

	public void chooseexercise(){
	
		exercise = excercisenumber();
		trials = trials +1;
		//Debug.Log (trials);

		if (trials > 5) {
			Application.LoadLevel("UserInstuction");
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
