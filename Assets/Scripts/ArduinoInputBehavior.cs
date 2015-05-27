using UnityEngine;
using System.Collections;
//using System.IO.Ports;

public class ArduinoInputBehavior : MonoBehaviour {

	private Instruction Instructionvalues;

	public GameObject Objeto;

	public int balance = 0;
	public int leftpos1; 
	public int leftpos2; 
	public int rightpos1; 
	public int rightpos2; 
	public int leftW1Red; 
	public int leftW2Yell; 
	public int rightW1Red;
	public int rightW2Yell;

	public bool pushbutton = false;
	public int whichbutton = 0; 

	
	// SerialPort arduinoinput = new SerialPort("COMX", 9600);

	// Use this for initialization
	void Start () 
	{
		Instructionvalues = Objeto.GetComponent<Instruction>();


		// SetWeigth(leftpos1, leftpos2, rightpos1, rightpos2, leftW1Red, leftW2Yell, rightW1Red, rightW2Yell);
	}
//		Debug.Log (balance);
//		
//		if (!GetComponent<Animation>().isPlaying) {
//			
//			if (balance == 1) {
//				GetComponent<Animation>().Play ("Balance Moves Left");//left
//			} else if (balance == 2) {
//				GetComponent<Animation>().Play ("Balance Moves Right");// Move Balance to the right
//			} else {
//				//Balance in equilibrium 
//			}
//		}
	 
	
	// Update is called once per frame

	void Update ()
	{
		leftpos1 = Instructionvalues.pnl1;
		leftpos2 = Instructionvalues.pnl2;
		rightpos1 = Instructionvalues.pnr1;
		rightpos2 = Instructionvalues.pnr2;
		leftW1Red = Instructionvalues.LeftW1;
		leftW2Yell = Instructionvalues.LeftW2;
		rightW1Red = Instructionvalues.RightW1;
		rightW2Yell = Instructionvalues.RightW2;

		SetWeigth(leftpos1, leftpos2, rightpos1, rightpos2, leftW1Red, leftW2Yell, rightW1Red, rightW2Yell);


	}



//	int TakeValuesArduino ()
//	{
//		// Some input will be somehow translated into values 1-4 for position and 1-2 for object
//		return leftpos1; 
//		return leftpos2; 
//		return rightpos1; 
//		return rightpos2; 
//		return leftW1; 
//		return leftW2;
//		return rightW1; 
//		return rightW2;
//	}


	//balance coded for 1 = left, 2 = right, 0 = balanced
	int SetWeigth (int leftpos1, int leftpos2, int rightpos1, int rightpos2, int leftW1, int leftW2, int rightW1, int rightW2)
	{
		int powerleft = leftpos1 * leftW1 + leftpos2 * leftW2;
		int powerright = rightpos1 * rightW1 + rightpos2 * rightW2;
		balance = 0;

		if (powerleft > powerright) {
			balance = 1;
		} 
		else if (powerleft < powerright) {
			balance = 2;
		} 

		return balance;

	}
	

//	void ScaleMove (balance)
//	{
//		if (balance = 1) {
//			// Move balance to the left
//		} else if (balance = 2) {
//			// Move Balance to the right
//		} else 
//		{
//			//Balance in equilibrium 
//		}
//	}
}
