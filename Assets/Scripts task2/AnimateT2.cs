using UnityEngine;
using System.Collections;

public class AnimateT2 : MonoBehaviour {
	
	private Calculateside Balancemovesto;
	public GameObject Balancemovestothe;

//	private bool leftPushed; 
//	public int whichbutton;
//	private int correctAns; 
	
	void Start () {
		
		Balancemovesto = Balancemovestothe.GetComponent<Calculateside>();
	}
	
	void Update () 
	{
//		print ("Button: "+ whichbutton + ", Correct answer: " +TakeVarHere.balance + ", score: " + score+ ", is correct?:"+ correct);
		
		//
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
	
//	public void setValueleft() 
//	{
//		whichbutton = 1;
//		//		print (whichbutton);
//	}
//	
//	public void setValueright() 
//	{
//		whichbutton = 2;
//		//		print (whichbutton);
//	}
//	public void setValuebalance() 
//	{
//		whichbutton = 0;
//		//		print (whichbutton);
//	}
	
//	public void compare()
//	{
//		if (whichbutton == TakeVarHere.balance) {
//			correct = 1;
//			score = score +1 ; 
//		}
//		else {
//			correct = 0;
//		}
//	}
	
	public void animate() 
	{
		if (!GetComponent<Animation>().isPlaying) {
			
			if (Balancemovesto.balance == 1) {
				GetComponent<Animation>().Play ("Balance Moves Left"); // Moves Balance to the left
			} 
			else if (Balancemovesto.balance == 2) {
				GetComponent<Animation>().Play ("Balance Moves Right"); // Move Balance to the right
			}  
			
		}
	}
	

}
