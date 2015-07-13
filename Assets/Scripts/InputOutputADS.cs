using UnityEngine;
using System.Collections;
using System;

public class InputOutputADS : MonoBehaviour {


	// Performance Parameters

	float performancetime;
	int numberofdata;
 	float performancecorrect;
	int targetperformance;
	int time;
	float lowerrorthreshold = .1f;
	float direction = 1f;

	public float error;
	public float maxError;
	public float previousError = 0;
	public int globalperformance;


	// Difficulty Parameters
	public float SVnumberofcubes;
	public float SVnumberofcolors;
	public float SVside;

	public float Parameternumberofcubes;
	public float Parameternumberofcolors;
	public float Parameterside;

	public float newParamCubes;
	public float newParamColor;
	public float newParamside;

	public float equalcolors;
	public float equalside;

	 public int[] totalPerformances = new int[7];
	 int performancenumber;

	 float performancetotal;
	
	//Calling values

	private GameObject ExerciseManager;
	private Textfile performdata;

	public GameObject Scale;
	private Animate Exercisedata;

	void Start(){

		//int[] totalPerformances = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
		int[] totalPerformances = {0,0,0,0,0,0,0};
		performancenumber = 7;

		targetperformance = 70;
		ExerciseManager = GameObject.Find ("Exercisemanager");
		performdata = ExerciseManager.GetComponent<Textfile> ();


		Exercisedata = Scale.GetComponent<Animate> ();
		//CalculatePerformance ();
	}

	public void SetFirstDifficulty(){
		Parameternumberofcubes = randomparameter ();
		Parameternumberofcolors = randomparameter ();
		Parameterside = randomparameter ();
		
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
		if (numberofdata <= 7) {
			numberofdata = numberofdata + 1;
		}

		totalPerformances[performancenumber] = Convert.ToInt32(performancetotal);

		if (performancenumber == 0){
			performancenumber = 7;
		}

		globalperformance = 0;
		foreach (int i in totalPerformances) {
		
			globalperformance = globalperformance + i;

		}
		globalperformance = (globalperformance / numberofdata);

		//RANDOM LINE SEARCH
		// calculate error 
		error = (targetperformance - globalperformance)/100f;
		Debug.Log (error);

		if (Mathf.Sign (error) > 0)
			direction = -1;
		else 
			direction = 1;

		// new step vector??

		if (error > previousError || (error > 0 && previousError < 0) || (error < 0 && previousError > 0)) {
			// calculate new step vector
			NewStepVector(true, true, true);
		} else {
			//same vector
		}

		// regulate error threshold

		maxError = Mathf.Max(Mathf.Abs(error), lowerrorthreshold);

		//vector addition
		bool outOfBounds = false;
		do {
			outOfBounds = false;
			newParamCubes = VectorAddition (Parameternumberofcubes, SVnumberofcubes);
			newParamColor = VectorAddition (Parameternumberofcolors, SVnumberofcolors);
			newParamside = VectorAddition (Parameterside, SVside);
			if (newParamCubes < 0 || newParamCubes > 1){
				outOfBounds = true;
				NewStepVector (false, true, true);
				newParamCubes = VectorAddition (Parameternumberofcubes, SVnumberofcubes);;
			}
			if (newParamColor < 0 || newParamColor > 1){
				outOfBounds = true;
				NewStepVector (true, false, true);
				newParamColor = VectorAddition (Parameternumberofcolors, SVnumberofcolors);
			}
			if (newParamside < 0 || newParamside > 1){
				outOfBounds = true;
				NewStepVector (true, true, false);
				newParamside = VectorAddition (Parameterside, SVside);
			}
		} while (false);
		Parameternumberofcubes = newParamCubes;
		Parameternumberofcolors = newParamColor;
		Parameterside = newParamside;

		previousError = error;

	}

	public float VectorAddition(float previousparameter, float stepvector){

		return previousparameter+stepvector*(Mathf.Sign(maxError)*.75f*maxError);
	}



	public void NewStepVector(bool cubes, bool colors, bool side) {
		if (cubes)
			SVnumberofcubes = randomparameter ()*direction;
		else
			SVnumberofcubes = 0;

		if (colors)
			SVnumberofcolors = randomparameter ()*direction;
		else
			SVnumberofcolors = 0;

		if (side)
			SVside = randomparameter ()*direction;
		else
			SVside = 0;
	}

	public float randomparameter(){

		return UnityEngine.Random.Range (0f, 1f);
	}





}
