using UnityEngine;
using System.Collections;

public class InputOutputADS : MonoBehaviour {

	// Use this for initialization

	int reactionTime;
	int numberOfErrors;
	int numberOfmovements;

	int numberofcubes;
	int numberofcolors;
	int numberofplaces;

	GameObject Instructions;
	Instruction Runlevel;


	void Start(){

		Instructions = GameObject.Find ("Instructions");
		Runlevel = Instructions.GetComponent<Instruction> ();

	}



	public void DeclareParameters () {
		 //I have no idea 

		ReceiveInputsADS ();

	}
	
	// Update is called once per frame
	public void ReceiveInputsADS () {

	// Read Inputs of the ADSystem


		numberofcubes = 1; //equal to inputs
		numberofcolors = 1;
		numberofplaces = 1;

		Runlevel.ADexercise();


	}

	public void SendOutputADS(){
	//Call the performance inputs and send them

		reactionTime = 3;
	    numberOfErrors = 2;
		numberOfmovements = 5;

		ReceiveInputsADS ();

		}


}
