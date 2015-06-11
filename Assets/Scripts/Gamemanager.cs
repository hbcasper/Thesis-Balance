using UnityEngine;
using System.Collections;

public class Gamemanager : MonoBehaviour {
	
	public int taskCount;
	public int levelnumber;
	public int performancelevel;

	private GameObject ScoreObject;
	private Animate Scorecode;

	ToogleOptions GameConfiguration;
	GameObject GameConfigurationToogles;
	

	public void addtrial(){
		taskCount = taskCount + 1;
		Debug.Log ("Trial Added"+taskCount.ToString()); 
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

		
	}

	public void PerformanceCalculator(){
		performancelevel = 50;
		if (taskCount >= 3) {
			performancelevel = ((Scorecode.score / taskCount)*100);
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
