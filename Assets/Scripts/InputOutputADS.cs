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
	int lowerrorthreshold = .1;

	public float error;
	public int previousError;
	public int globalperformance;
	int SVdistance;

	// Difficulty Parameters
	public int SVnumberofcubes;
	public int SVnumberofcolors;

	public int Parameternumberofcubes;
	public int Parameternumberofcolors;
	public int Parameterdistance;

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

	public void SetFirstDifficulty(){
		Parameternumberofcubes = randomparameter ();
		Parameternumberofcolors = randomparameter ();
		Parameterdistance = randomparameter ();
		
		GameObject.Find("Instructions").GetComponent<Instruction> ().ADexercise ();
	}

	public void CalculatePerformance(){
			
		if (Exercisedata.correct == 0) {
			performancecorrect = 0;
		} else if (Exercisedata.correct == 1){
			performancecorrect = 100;
		}

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
		error = (targetperformance - globalperformance)/100;

		if (error > previousError || (error > 0 && previousError < 0) || (error < 0 && previousError > 0)) {
			NewStepVector();
		} else {
			//same vector
		}

		error = Mathf.Min (error, lowerrorthreshold);

		VectorAddition (Parameternumberofcubes, SVnumberofcubes);
		VectorAddition (Parameternumberofcolors,SVnumberofcolors);
		VectorAddition (Parameterdistance, SVdistance);

		runexcercise();

		previousError = error;

	}

	public float VectorAddition(float previousparameter,float stepvector){

		previousparameter+stepvector+(Mathf.Sign(error)*.5*error);

	}

	public void runexcercise(){
		GameObject.Find("Instructions").GetComponent<Instruction> ().ADexercise ();
	}

	public void NewStepVector() {

		SVnumberofcubes = randomparameter ();
		SVnumberofcolors = randomparameter ();
		SVdistance = randomparameter ();

	}

	public int randomparameter(){

		Random.Range (0, 1);
	

	}





}
