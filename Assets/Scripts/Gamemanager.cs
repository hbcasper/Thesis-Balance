using UnityEngine;
using System.Collections;

public class Gamemanager : MonoBehaviour {
	
	public int taskCount;
	public int score;
	public int levelnumber;
	public float performancelevel;
	public int adaptiveTaskNumber;

//	public int pretestCount; 
//	bool pretest; 

	private GameObject ScoreObject;
	private Animate Scorecode;

	ToogleOptions GameConfiguration;
	GameObject GameConfigurationToogles;


//	public void addPretestCount (){
//		pretestCount = pretestCount + 1; 
//		if (pretestCount > 5) {
//			pretest = false; 
//		}
//	}

	public void addtrial(){

			taskCount = taskCount + 1;


			adaptiveTaskNumber = adaptiveTaskNumber + 1;
		
	}

	void Update(){
		score = Scorecode.score;
	}

	void Start (){
		ScoreObject = GameObject.Find ("Scale");
		Scorecode = ScoreObject.GetComponent<Animate>();
//		pretest = true; 

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
		 
		//pretestCount = 1; 

		taskCount = 1;
		adaptiveTaskNumber = 1;

	}

	public void PerformanceCalculator(){

		if (GameConfiguration.ActiveAdaptiveLevels == true) {


			if (adaptiveTaskNumber > 4) {
				adaptiveTaskNumber = 1;
			}


			if (taskCount > 4) {
				performancelevel = ((score * 100) / taskCount);
			} else {
				performancelevel = 50;
			}
		}
	}


			
	public void Checklevel (){


		if(GameConfiguration.ActiveAdaptiveLevels == true) {
				if (taskCount == 31) {
				Application.LoadLevel ("Posttesthotair");
				}
				}

		else {
		
				if (taskCount <= 5) {
					levelnumber = 1; 
					
				} else if (taskCount <= 10) {
					levelnumber = 2;
					
				} else if (taskCount <= 20) {
					levelnumber = 3;
					
				} else if (taskCount <= 30) {
					levelnumber = 4;
				}else if (taskCount == 31) {
				Application.LoadLevel ("Posttesthotair");
					
			}
		}
	}
}
