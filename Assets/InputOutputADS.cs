using UnityEngine;
using System.Collections;
using System;

public class InputOutputADS : MonoBehaviour {


	// Performance Parameters
	public float reactionTime;
	public float answercorrect;

	// Difficulty Parameters
	public float numberofcubes;
	public float numberofcolors;
	public float equalcolors;
	public float equaldistance;
	
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

	public void DeclareParameters () {
		 //I have no idea of how to
		ReceiveInputsADS ();
	}

	public void ReceiveInputsADS () {

	// Read Inputs of the ADSystem

	// all the values should be from  0 to 1

		numberofcubes = 1; //(0-1) 0 = 1 cube - 1 = 2 cubes
		numberofcolors = 1; //(0- 1) 0 = 1 color - 1 = 2 colors
		equalcolors = 1; //(0-1) 0 = Same colos en each side 1 = Different color in each side
		equaldistance = 1; // ( 0 -1) 0 = Same distance on each side 1 = Different distance in each side

		GameObject Instructions = GameObject.Find ("Instructions");
		Instructions.GetComponent<Instruction> ().ADexercise ();

	}

	public void SendOutputADS(){

		// all the values are from 0 - 1 

		reactionTime = Convert.ToSingle(performdata.endTime.Second) /100; // NECESSARY to pass from 0 -1 
	    answercorrect = Convert.ToSingle (Exercisedata.correct); // 0-1 0 = Incorrect. 1 = Correct
	
		ReceiveInputsADS ();

		}


}
