using UnityEngine;
using System.Collections;

public class Gamemanager : MonoBehaviour {
	
	public int taskCount;
	public int levelnumber;
	

	public void addtrial(){
		taskCount = taskCount + 1;
	}

	void Start (){
		taskCount = 1;
		levelnumber = 1;
	}

			
	public void Checklevel (){
		
		if (taskCount <= 5) {
			levelnumber=1;

		} 
		else if (taskCount <= 10) 
		{
			levelnumber=2;

		} 
		else if (taskCount <= 25) 
		{
			levelnumber=3;

		}
		else if (taskCount <= 40) 
		{
			levelnumber=4;

		}
		else if (taskCount == 41) 
		{
			Application.LoadLevel("UserInstructionTask2");
			
		}
	}
}
