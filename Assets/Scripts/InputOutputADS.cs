using UnityEngine;
using System.Collections;
using System;

public class InputOutputADS : MonoBehaviour {


	// Performance Parameters
	public float reactionTime;
	public float answercorrect;
	public int performancetime;
	public int performancecorrect;
	public int targetperformance;

	// Difficulty Parameters
	public int numberofcubes;
	public int numberofcolors;
	public float equalcolors;
	public float equaldistance;

	public int performancetotal;
	
	//Calling values

	private GameObject ExerciseManager;
	private Textfile performdata;

	public GameObject Scale;
	private Animate Exercisedata;

	void Start(){
		targetperformance = 70;
		ExerciseManager = GameObject.Find ("Exercisemanager");
		performdata = ExerciseManager.GetComponent<Textfile> ();


		Exercisedata = Scale.GetComponent<Animate> ();
		CalculatePerformance ();
	}


	public void CalculatePerformance(){

		// calculate performance parameters 
	
		if (Exercisedata.correct == 0) {
			performancecorrect = 0;
		} else {
			answercorrect = 100;
		}
		// performance time

			

		if (performdata.reactionTime3.TotalMilliseconds < 60) {
			performancetime = 100;
		} else if (performdata.reactionTime3.Seconds < 90) {
			performancetime = 80;
		}  else if (performdata.reactionTime3.Seconds < 120) {
			performancetime = 60;
		} else if (performdata.reactionTime3.Seconds < 150) {
			performancetime = 40;
		} else if (performdata.reactionTime3.Seconds < 180) {
			performancetime = 20;
		} else if (performdata.reactionTime3.Seconds >= 180) {
			performancetime = 0;
		}

		//Calculate performance
		performancetotal = ((performancetime + performancecorrect) / 2);

		if (performancetotal >= 70) {

		}
		if (performancetotal <= 40) {

		}
		SetDifficulty ();
	}

	public void SetDifficulty () {

	// read performance

	//Calculate new level

		numberofcubes = 1; //1-2 cubes
		numberofcolors = 1; //1-2 colors
		equalcolors = 1; //1-2 1 = Same colos en each side 2 = Different color in each side
		equaldistance = 1; // ( 0 -1) 0 = Same distance on each side 1 = Different distance in each side

		GameObject Instructions = GameObject.Find ("Instructions");
		Instructions.GetComponent<Instruction> ().ADexercise ();

	}



}
