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


//		leftPushed = GameObject.Find("LEFT").GetComponent<ButtonLeft>().pushed;
//
//		if ((!GetComponent<Animation>().isPlaying) && leftPushed) {
//			print ("button pushed");
//			
//			if (TakeVarHere.balance == 1) {
//				GetComponent<Animation>().Play ("Balance Moves Left"); //left
//			} else if (TakeVarHere.balance == 2) {
//				GetComponent<Animation>().Play ( "Balance Moves Right"); // Move Balance to the right
//			}  
//		}
	}

	public void setValueleft() 
	{
		whichbutton = 1;
//		print (whichbutton);
	}

	public void setValueright() 
	{
		whichbutton = 2;
//		print (whichbutton);
	}
	public void setValuebalance() 
	{
		whichbutton = 0;
		//		print (whichbutton);
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

//	int SetWeigth (int leftpos1, int leftpos2, int rightpos1, int rightpos2, int leftW1, int leftW2, int rightW1, int rightW2)
//	{
//		int powerleft = leftpos1 * leftW1 + leftpos2 * leftW2;
//		int powerright = rightpos1 * rightW1 + rightpos2 * rightW2;
//
//		TakeVarHere.balance = 0;
//		
//		if (powerleft > powerright) {
//			TakeVarHere.balance = 1;
//		} 
//		else if (powerleft < powerright) {
//			TakeVarHere.balance = 2;
//		} 
//		
//		return TakeVarHere.balance;
//		
//	}
	
}
