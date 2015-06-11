﻿using UnityEngine;
using System.Collections;

public class Gamemanager : MonoBehaviour {
	
	public int taskCount;
	public int score;
	public int levelnumber;
	public float performancelevel;
	public int adaptiveTaskNumber;

	private GameObject ScoreObject;
	private Animate Scorecode;

	ToogleOptions GameConfiguration;
	GameObject GameConfigurationToogles;
	

	public void addtrial(){
		taskCount = taskCount + 1;

		Debug.Log ("Trial Added"+taskCount.ToString());

		adaptiveTaskNumber = adaptiveTaskNumber+1;
	}

	void Update(){
		score = Scorecode.score;
	}
	void Start (){
		ScoreObject = GameObject.Find ("Scale");
		Scorecode = ScoreObject.GetComponent<Animate>();


		if (GameObject.Find ("GameConfiguration") == true) {
			GameConfigurationToogles = GameObject.Find ("GameConfiguration");
			GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions> ();

			if (GameConfiguration.ActiveAdaptiveDificulty == true) {
				levelnumber = 0;
			} else {
				levelnumber = 1;
			}
			if 
			(GameConfiguration.ActiveAdaptiveLevels == true) {
				PerformanceCalculator ();
			} else {
				levelnumber = 1;
			}
		}

		taskCount = 1;
		adaptiveTaskNumber = 1;

		
	}

	public void PerformanceCalculator(){



		if (adaptiveTaskNumber >4){
			adaptiveTaskNumber = 1;
		}


		if (taskCount > 4) {
			performancelevel = ((score * 100) / taskCount);
		} else {
			performancelevel = 50;
		}
	}


			
	public void Checklevel (){


		if (GameObject.Find ("GameConfiguration") == true)
		{
			if(GameConfiguration.ActiveAdaptiveDificulty == true || GameConfiguration.ActiveAdaptiveLevels == true) {
				if (taskCount == 41) {
					Application.LoadLevel ("UserInstructionTask2");
				}
				}
		}

		else {if (taskCount <= 5) {
				levelnumber = 1;
				
			} else if (taskCount <= 10) {
				levelnumber = 2;
				
			} else if (taskCount <= 25) {
				levelnumber = 3;
				
			} else if (taskCount <= 40) {
				levelnumber = 4;
				
			} else if (taskCount == 41) {
				Application.LoadLevel ("UserInstructionTask2");
				
			}
		}

	}
}
