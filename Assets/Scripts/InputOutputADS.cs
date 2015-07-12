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
	float lowerrorthreshold = .1f;

	public float error;
	public float previousError = 0;
	public int globalperformance;


	// Difficulty Parameters
	public float SVnumberofcubes;
	public float SVnumberofcolors;
	public float SVdistance;

	public float Parameternumberofcubes;
	public float Parameternumberofcolors;
	public float Parameterdistance;

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

		//measure performance
			
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

		//RANDOM LINE SEARCH
		// calculate error 
		error = (targetperformance - globalperformance)/100;

		// new step vector??

		if (error > previousError || (error > 0 && previousError < 0) || (error < 0 && previousError > 0)) {
			// calculate new step vector
			NewStepVector(true, true, true);
		} else {
			//same vector
		}

		// regulate error threshold

		error = Mathf.Min (error, lowerrorthreshold);

		//vector addition
		bool outOfBounds = false;
		do {
			outOfBounds = false;
			Parameternumberofcubes = VectorAddition (Parameternumberofcubes, SVnumberofcubes);
			Parameternumberofcolors = VectorAddition (Parameternumberofcolors, SVnumberofcolors);
			Parameterdistance = VectorAddition (Parameterdistance, SVdistance);
			if (Parameternumberofcubes < 0 || Parameternumberofcubes > 1){
				outOfBounds = true;
				NewStepVector (false, true, true);
			}
			else if (Parameternumberofcolors < 0 || Parameternumberofcolors > 1){
				outOfBounds = true;
				NewStepVector (true, false, true);
			}
			else if (Parameterdistance < 0 || Parameterdistance > 1){
				outOfBounds = true;
				NewStepVector (true, true, false);
			}
		} while (outOfBounds);
		runexcercise();

		previousError = error;

	}

	public float VectorAddition(float previousparameter, float stepvector){

		return previousparameter+stepvector+(Mathf.Sign(error)*.5f*error);
	}

	public void runexcercise(){
		GameObject.Find("Instructions").GetComponent<Instruction> ().ADexercise ();
	}

	public void NewStepVector(bool cubes, bool colors, bool distance) {
		if (cubes)
			SVnumberofcubes = randomparameter ();
		else
			SVnumberofcubes = 0;

		if (colors)
			SVnumberofcolors = randomparameter ();
		else
			SVnumberofcolors = 0;

		if (distance)
			SVdistance = randomparameter ();
		else
			SVdistance = 0;
	}

	public float randomparameter(){

		return Random.Range (0, 1);
	}





}
