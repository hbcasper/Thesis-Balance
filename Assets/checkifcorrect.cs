﻿using UnityEngine;
using System.Collections;

public class checkifcorrect : MonoBehaviour {


	randomexercise exercisenumber;
	public string exercise;
	string scene;
	public int correctanswer;
	public int answer;
	public string pressed;
	public string answerlog;
	public int count;
	string performance;
	public int trials;
	// Use this for initialization
	void Start () {
		scene = Application.loadedLevelName;
		trials = 0;

	
		exercisenumber = gameObject.GetComponent<randomexercise> ();
	
	}
	
	// Update is called once per frame
	public void correctanwsers () {

		exercise = exercisenumber.exercise;

		if (scene == "Pretest") {
			if (exercise == "1") {
				correctanswer = 5;
			} else if (exercise == "2") {
				correctanswer = 1;
			} else if (exercise == "3") {
				correctanswer = 10;
			} else if (exercise == "4") {
				correctanswer = 12;
			} else if (exercise == "5") {
				correctanswer = 3;
			}
			   



		}
	}

		public void checkcorrect(){
		correctanwsers ();

		if (pressed == correctanswer.ToString()) {

			answer = 1;
		} else {
			answer = 0;
		}
		correctcount ();
		pressed = "0";

		}

	void correctcount(){
		answerlog = answerlog + answer.ToString() + ",";
		count = count + answer;
		Debug.Log ("correct count" +count);
		Debug.Log ("answerlog"+answerlog);

	}
	public void performanceanswer(){


		performance = performance + pressed + ",";
		Debug.Log ("performance"+performance);
		
		trials = trials +1;
		Debug.Log ("trials"+trials);
		//Debug.Log (trials);
		
		if (trials >4) {
			Application.LoadLevel("UserInstuction");
		}
		
	}
	
	
}

