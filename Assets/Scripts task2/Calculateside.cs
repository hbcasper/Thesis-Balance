using UnityEngine;
using System.Collections;
//using System.IO.Ports;

public class Calculateside : MonoBehaviour {

	//Calling values inside the cubes from ReceivedweightT2
	private ReceivedweightT2 LeftCube1;
	private ReceivedweightT2 LeftCube2;
	private ReceivedweightT2 LeftCube3;
	private ReceivedweightT2 LeftCube4;
	private ReceivedweightT2 LeftCube5;
	private ReceivedweightT2 LeftCube6;
	private ReceivedweightT2 RightCube1;
	private ReceivedweightT2 RightCube2;
	private ReceivedweightT2 RightCube3;
	private ReceivedweightT2 RightCube4;
	private ReceivedweightT2 RightCube5;
	private ReceivedweightT2 RightCube6;

	public GameObject InsideLeftCube1;
	public GameObject InsideLeftCube2;
	public GameObject InsideLeftCube3;
	public GameObject InsideLeftCube4;
	public GameObject InsideLeftCube5;
	public GameObject InsideLeftCube6;
	public GameObject InsideRightCube1;
	public GameObject InsideRightCube2;
	public GameObject InsideRightCube3;
	public GameObject InsideRightCube4;
	public GameObject InsideRightCube5;
	public GameObject InsideRightCube6;

	int weightL1; 
	int weightL2;
	int weightL3;
	int weightL4;
	int weightL5;
	int weightL6;
	int weightR1;
	int weightR2;
	int weightR3;
	int weightR4;
	int weightR5;
	int weightR6;


	public int balance = 0;

	// Use this for initialization
	void Start () 
	{
		LeftCube1 = InsideLeftCube1.GetComponent<ReceivedweightT2>();
		LeftCube2 = InsideLeftCube2.GetComponent<ReceivedweightT2>();
		LeftCube3 = InsideLeftCube3.GetComponent<ReceivedweightT2>();
		LeftCube4 = InsideLeftCube4.GetComponent<ReceivedweightT2>();
		LeftCube5 = InsideLeftCube5.GetComponent<ReceivedweightT2>();
		LeftCube6 = InsideLeftCube6.GetComponent<ReceivedweightT2>();
		RightCube1 = InsideRightCube1.GetComponent<ReceivedweightT2>();
		RightCube2 = InsideRightCube2.GetComponent<ReceivedweightT2>();
		RightCube3 = InsideRightCube3.GetComponent<ReceivedweightT2>();
		RightCube4 = InsideRightCube4.GetComponent<ReceivedweightT2>();
		RightCube5 = InsideRightCube5.GetComponent<ReceivedweightT2>();
		RightCube6 = InsideRightCube6.GetComponent<ReceivedweightT2>();


		// SetWeigth(leftpos1, leftpos2, rightpos1, rightpos2, leftW1Red, leftW2Yell, rightW1Red, rightW2Yell);
	}

	
	// Update is called once per frame

	void Update ()
	{
		Calculatebalance(LeftCube1.Imthecubenumber,LeftCube1.Cubereceivesweight,LeftCube2.Imthecubenumber,LeftCube2.Cubereceivesweight,LeftCube3.Imthecubenumber,LeftCube3.Cubereceivesweight,
		              LeftCube4.Imthecubenumber,LeftCube4.Cubereceivesweight,LeftCube5.Imthecubenumber,LeftCube5.Cubereceivesweight,LeftCube6.Imthecubenumber,LeftCube6.Cubereceivesweight,
		              RightCube1.Imthecubenumber,RightCube1.Cubereceivesweight,RightCube2.Imthecubenumber,RightCube2.Cubereceivesweight,RightCube3.Imthecubenumber,RightCube3.Cubereceivesweight,
		              RightCube4.Imthecubenumber,RightCube4.Cubereceivesweight,RightCube5.Imthecubenumber,RightCube5.Cubereceivesweight,RightCube6.Imthecubenumber,RightCube6.Cubereceivesweight);
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
	int Calculatebalance (int leftW1, int CleftW1, int leftW2, int CleftW2, int leftW3, int CleftW3, int leftW4, int CleftW4, int leftW5, int CleftW5, int leftW6, int CleftW6,
	                   int rightW1, int CrightW1, int rightW2, int CrightW2, int rightW3, int CrightW3, int rightW4, int CrightW4, int rightW5, int CrightW5,int rightW6, int CrightW6)
	{
		int powerleft = leftW1 * CleftW1 + leftW2 * CleftW2 + leftW3 * CleftW3 + leftW4 * CleftW4 + leftW5 * CleftW5 + leftW6 * CleftW6;
		int powerright = rightW1 * CrightW1 + rightW2 * CrightW2 + rightW3 * CrightW3 + rightW4 * CrightW4 + rightW5 * CrightW5 + rightW6 * CrightW6;

		if (powerleft > powerright) {
			balance = 1;
		} 
		else if (powerleft < powerright) {
			balance = 2;
		} 
		else if (powerleft == powerright) {
			balance = 0;
		}

		return balance;

	}
}
