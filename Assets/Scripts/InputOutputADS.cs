using UnityEngine;
using System.Collections;
using System;

public class InputOutputADS : MonoBehaviour {


	// Performance Parameters
	public float reactionTime;
	public float answercorrect;

	// Difficulty Parameters
	public int numberofcubes;
	public int numberofcolors;
	public float equalcolors;
	public float equaldistance;

	float performancelevel;
	
	//Calling values

	private GameObject ExerciseManager;
	private Textfile performdata;

	private GameObject Scale;
	private Animate Exercisedata;

	void Start(){
		ExerciseManager = GameObject.Find ("Exercisemanager");
		performdata = ExerciseManager.GetComponent<Textfile> ();

		Scale = GameObject.Find ("Scale");
		Exercisedata = Scale.GetComponent<Animate> ();
	}


	public void CalculatePerformance(){



		// Read performance parameters 
		reactionTime = Convert.ToSingle(performdata.endTime.Second); // number of seconds 
		answercorrect = Convert.ToSingle (Exercisedata.correct); //correct or incorrect 0 -1 

		//Calculate performance

		if (performancelevel >= 70) {

		}
		if (performancelevel <= 40) {

		}
		SetDifficulty ();
	}

	public void SetDifficulty () {

	// read performance

	//Calculate new level
		numberofcubes = 1; //1-2 cubes
		numberofcolors = 1; //1-2 colors
		equalcolors = 1; //(0-1) 0 = Same colos en each side 1 = Different color in each side
		equaldistance = 1; // ( 0 -1) 0 = Same distance on each side 1 = Different distance in each side

		GameObject Instructions = GameObject.Find ("Instructions");
		Instructions.GetComponent<Instruction> ().ADexercise ();

	}



}
