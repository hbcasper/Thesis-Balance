using UnityEngine;
using System.Collections;

public class GamemanagerT2 : MonoBehaviour {
	
	public int taskCount;
	public int levelnumber;

	public LevelBehaviorT2 Runlevel;

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
			Runlevel.level1();
		} 
		else if (taskCount <= 10) 
		{
			levelnumber=2;
			Runlevel.level2();
		} 
		else if (taskCount <= 25) 
		{
			levelnumber=3;
			Runlevel.level3();
		}
		else if (taskCount <= 40) 
		{
			levelnumber=4;
			Runlevel.level4();
		}
		else if (taskCount == 41) 
		{
			Debug.Log("ready");
			Application.LoadLevel("UserInstructionTask2");
		}
	}
}
