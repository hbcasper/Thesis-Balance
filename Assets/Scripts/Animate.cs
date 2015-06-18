using UnityEngine;
using System.Collections;

	public class Animate : MonoBehaviour {

	private ArduinoInputBehavior TakeVarHere;
	private bool leftPushed; 
	public int whichbutton;
	private int correctAns; 
	public int correct; 
	public int score; 
	public int correctToLog;


	void Start () {
		TakeVarHere = gameObject.GetComponent<ArduinoInputBehavior>();
	}

	void Update ()
	{
		print ("Button: "+ whichbutton + ", Correct answer: " +TakeVarHere.balance + ", score: " + score+ ", is correct?:"+ correct);
		
	}

	public void setValueleft() 
	{
		whichbutton = 1;
	}

	public void setValueright() 
	{
		whichbutton = 2;
	}
	public void setValuebalance() 
	{
		whichbutton = 0;
	}

	public void compare()
	{
		if (whichbutton == TakeVarHere.balance) {
			correct = 1;
			score = score +1 ; 
			correctToLog = correct; 
		}
		else {
			correct = 0;
		}
	}

	public void animate() 
	{
		if (!GetComponent<Animation>().isPlaying) {
			
			if (TakeVarHere.balance == 1) {
				GetComponent<Animation>().Play ("Balance Moves Left"); // Moves Balance to the left
			} 
			else if (TakeVarHere.balance == 2) {
				GetComponent<Animation>().Play ("Balance Moves Right"); // Move Balance to the right
			}  

		}
	}
}
