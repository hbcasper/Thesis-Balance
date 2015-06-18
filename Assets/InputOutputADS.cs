using UnityEngine;
using System.Collections;

public class InputOutputADS : MonoBehaviour {

	// Use this for initialization

	public int reactionTime;
	public int answercorrect;
	public int numberOfmovements;

	public int numberofcubes;
	public int numberofcolors;
	public int equalcolors;

	private GameObject ExerciseManager;
	private Textfile performdata;

	private GameObject Scale;
	private Animate Exercisedata;
	//GameObject Instructions;
	//Instruction Runlevel;


	void Start(){
		ExerciseManager = GameObject.Find ("Exercisemanager");
		performdata = ExerciseManager.GetComponent<Textfile> ();

		Scale = GameObject.Find ("Scale");
		Exercisedata = Scale.GetComponent<Animate> ();
		//Runlevel = Instructions.GetComponent<Instruction> ();
	}



	public void DeclareParameters () {
		 //I have no idea 

		ReceiveInputsADS ();


	}
	
	// Update is called once per frame
	public void ReceiveInputsADS () {

	// Read Inputs of the ADSystem

		// all the values are from  0 to 1


		numberofcubes = 3; //(1-6)
		numberofcolors = 3; //(1-3)
		equalcolors = 2; //(1-2)

		GameObject Instructions = GameObject.Find ("Instructions");
		Instructions.GetComponent<Instruction> ().ADexercise ();

	}

	public void SendOutputADS(){

		// all the values are from 0 - 1 

		reactionTime = performdata.StoreEndTime/ 100; // number of seconds how to mapp it?
	    answercorrect = Exercisedata.correct; // 0-1
		//code for send it


		ReceiveInputsADS ();

		}


}
