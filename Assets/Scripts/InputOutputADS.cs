using UnityEngine;
using System.Collections;
//using System;

public class InputOutputADS : MonoBehaviour {


	// Performance Parameters

	 int performancetime;
	int numberofdata;
 int performancecorrect;
	int targetperformance;
	 int time;
	int lowerrorthreshold = 10;

	public float error;
	public int previousError;
	public int globalperformance;
	int distance;

	// Difficulty Parameters
	public int numberofcubes;
	public int numberofcolors;
	public float equalcolors;
	public float equaldistance;

	 public int[] totalPerformances = new int[15];
	 int performancenumber;

	 int performancetotal;
	
	//Calling values

	private GameObject ExerciseManager;
	private Textfile performdata;

	public GameObject Scale;
	private Animate Exercisedata;

	void Start(){

		int[] totalPerformances = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

		performancenumber = 15;

		targetperformance = 70;
		ExerciseManager = GameObject.Find ("Exercisemanager");
		performdata = ExerciseManager.GetComponent<Textfile> ();


		Exercisedata = Scale.GetComponent<Animate> ();
		//CalculatePerformance ();
	}


	public void CalculatePerformance(){


	

		// calculate performance parameters 
	
		if (Exercisedata.correct == 0) {
			performancecorrect = 0;
		} else if (Exercisedata.correct == 1){
			performancecorrect = 100;
		}
		// performance time

		if (performdata.reactionTime2.Seconds < 1) {
			performancetime = 100;

		}
		else if (performdata.reactionTime2.Seconds == 1 && performdata.reactionTime2.Milliseconds <= 500) {
				performancetime = 80;
			}
		 else if (performdata.reactionTime2.Seconds == 1 && performdata.reactionTime2.Milliseconds > 500) {
			performancetime = 60;
		}
			else if (performdata.reactionTime2.Seconds == 2 && performdata.reactionTime2.Milliseconds <= 500) {
		performancetime = 40;}
		 else if (performdata.reactionTime2.Seconds < 3) {
			performancetime = 20;
		} else if (performdata.reactionTime2.Seconds >= 3) {
			performancetime = 0;
		}

		//Calculate performance
		performancetotal = ((performancetime + performancecorrect) / 2);



		performancenumber = performancenumber - 1;
		if (numberofdata <= 15) {
			numberofdata = numberofdata + 1;
		}

		totalPerformances [performancenumber] = performancetotal;


		if (performancenumber == 0){
			performancenumber = 15;
		}

		globalperformance = 0;
		foreach (int i in totalPerformances) {
		
			globalperformance = globalperformance + i;

		}
		globalperformance = (globalperformance / numberofdata);
		error = targetperformance - globalperformance;

		if (error > previousError || (error > 0 && previousError < 0) || (error < 0 && previousError > 0)) {
			CalculateNewVector();
		} else {
			//same vector
		}

		error = Mathf.Min (error, lowerrorthreshold);

		VectorAddition ();

		previousError = error;

		
	

		//SetDifficulty ();
	}

	public float VectorAddition(float previousparameter,float stepvector,float stepsize){

		previousparameter+stepvector+(Mathf.Sign(error)*1*error);

	}


	public void CalculateNewVector(){


	}

	public void SetDifficulty () {

	
	//Calculate new level

		numberofcubes = randomparameter (1, 2);
		numberofcolors = randomparameter (1, 2);
		distance = randomparameter (1, 11);
		//equalcolors = 1; //1-2 1 = Same colos en each side 2 = Different color in each side
		//equaldistance = 1; // ( 0 -1) 0 = Same distance on each side 1 = Different distance in each side

	
		GameObject.Find("Instructions").GetComponent<Instruction> ().ADexercise ();

		 

	}

	public int randomparameter(int minvalue, int maxvalue){

		Random.Range (minvalue, maxvalue);
	

	}



}
