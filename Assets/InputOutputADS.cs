using UnityEngine;
using System.Collections;

public class InputOutputADS : MonoBehaviour {

	// Use this for initialization

	public int reactionTime;
	public int numberOfErrors;
	public int numberOfmovements;

	public int numberofcubes;
	public int numberofcolors;
	public int equalcolors;

	GameObject Instructions;
	Instruction Runlevel;


	void Start(){

		Instructions = GameObject.Find ("Instructions");
		Runlevel = Instructions.GetComponent<Instruction> ();

	}



	public void DeclareParameters () {
		 //I have no idea 

		ReceiveInputsADS ();
		Debug.Log ("Gothere3");

	}
	
	// Update is called once per frame
	public void ReceiveInputsADS () {

	// Read Inputs of the ADSystem


		numberofcubes = 3; //(1-6)
		numberofcolors = 3; //(1-3)
		equalcolors = 2; //(1-2)

		Runlevel.ADexercise();
		Debug.Log ("Gothere4");

	}

	public void SendOutputADS(){
	//Call the performance inputs and send them

		reactionTime = 3;
	    numberOfErrors = 2;
		numberOfmovements = 5;

		ReceiveInputsADS ();

		}


}
