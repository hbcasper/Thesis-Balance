using UnityEngine;
using System.Collections;

public class Gamemanager : MonoBehaviour {
	
	public int taskCount;
	public int levelnumber;

	ToogleOptions GameConfiguration;
	GameObject GameConfigurationToogles;
	

	public void addtrial(){
		taskCount = taskCount + 1;
		Debug.Log ("Trial Added"+taskCount.ToString()); 
	}

	void Start (){
		taskCount = 1;
		levelnumber = 1;
	}

			
	public void Checklevel (){

		// If augmented reality = false

		
		if (GameObject.Find ("GameConfiguration") == null) {
		
			if (taskCount <= 5) {
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
		else {
				GameConfigurationToogles = GameObject.Find ("GameConfiguration");
				GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
				
				levelnumber = 0; 

				if (taskCount == 41) {
					Application.LoadLevel ("UserInstructionTask2");
				}
				}

	}
}
