using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Desactivebutton : MonoBehaviour {

	public Transform button;

//  Variables used to compare Userplacement of weights with placement given in Instructions
//	public int colorCube1;
//	public int colorCube2;
//	public int colorCube3;
//	public int colorCube4;

//	public int positionCube1;
//	public int positionCube2;
//	public int positionCube3;
//	public int positionCube4;
//
//	public bool correctPosition;

	//Calling cube values

	private Checkcorrect Cube1result;
	public GameObject LeftCube1;

	private Checkcorrect Cube2result;
	public GameObject LeftCube2;

	private Checkcorrect Cube3result;
	public GameObject LeftCube3;

	private Checkcorrect Cube4result;
	public GameObject LeftCube4;

	private Checkcorrect Cube5result;
	public GameObject LeftCube5;

	private Checkcorrect Cube6result;
	public GameObject RightCube1;

	private Checkcorrect Cube7result;
	public GameObject RightCube2;

	private Checkcorrect Cube8result;
	public GameObject RightCube3;

	private Checkcorrect Cube9result;
	public GameObject RightCube4;

	private Checkcorrect Cube10result;
	public GameObject RightCube5;

	private Checkcorrect Cube11result;
	public GameObject RightCube6;

	private Checkcorrect Cube12result;
	public GameObject LeftCube6;

//  Source of the User Weight Placement as well as the Instructions
//	private Instruction RightSetting;
//	private GameObject rightSetting;
//
//	private ArduinoConnect UserSetting;
//	private GameObject userSetting; 

	// Use this for initialization
	void Start () {
		Cube1result = LeftCube1.GetComponent<Checkcorrect> ();
		Cube2result = LeftCube2.GetComponent<Checkcorrect> ();
		Cube3result = LeftCube3.GetComponent<Checkcorrect> ();
		Cube4result = LeftCube4.GetComponent<Checkcorrect> ();
		Cube5result = LeftCube5.GetComponent<Checkcorrect> ();
		Cube6result = RightCube1.GetComponent<Checkcorrect> ();
		Cube7result = RightCube2.GetComponent<Checkcorrect> ();
		Cube8result = RightCube3.GetComponent<Checkcorrect> ();
		Cube9result = RightCube4.GetComponent<Checkcorrect> ();
		Cube10result = RightCube5.GetComponent<Checkcorrect> ();
		Cube11result = RightCube6.GetComponent<Checkcorrect> ();
		Cube12result = LeftCube6.GetComponent<Checkcorrect> ();

//		rightSetting = GameObject.Find ("Instructions"); 
//		RightSetting = rightSetting.GetComponent<Instruction> (); 
//
//		userSetting = GameObject.Find ("Exercisemanager");
//		UserSetting = userSetting.GetComponent<ArduinoConnect> ();

//	 	Variables needed to compare user Placement of Weights with Instruction 
//		colorCube1 = 0;
//		colorCube2 = 0;
//		colorCube3 = 0;
//		colorCube4 = 0; 
//
//		positionCube1 = 0; 
//		positionCube2 = 0;
//		positionCube3 = 0;
//		positionCube4 = 0; 


	}

// call this function sometime after the Instructions are displayed
//	void compareCubes(){
//
//		while (positionCube1 == 0) {
//			positionCube1 = UserSetting.position1; 
//		}
//		while (positionCube2 == 0) {
//			positionCube2 = UserSetting.position2; 
//		}
//
//		if (positionCube1 == RightSetting.pnl1 && positionCube2 == RightSetting.pnr1) {
//			correctPosition = true; 
//		}
//
//	}


	
	// Update is called once per frame
	void Update () {
		// add correctPosition &&  to if-Condition when clear where it is called
			if (Cube1result.result == "correct" && Cube2result.result == "correct" && Cube3result.result == "correct" && Cube4result.result == "correct" && Cube5result.result == "correct" && Cube6result.result == "correct" && Cube7result.result == "correct" && Cube8result.result == "correct" && Cube9result.result == "correct" && Cube10result.result == "correct" && Cube11result.result == "correct" && Cube12result.result == "correct")
		{

		button.GetComponent<Button>().interactable = true; 
	
		}

	else
		{

		button.GetComponent<Button>().interactable = false; 
		}
	}

}
