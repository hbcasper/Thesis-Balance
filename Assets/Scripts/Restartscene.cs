﻿ //using UnityEngine;
//using System.Collections;
//
//public class Restartscene : MonoBehaviour {
//
//	private GameObject Readybutton;
//	private GameObject Instructions;
//	private GameObject Scale;
////	private GameObject Nextexercise;
////	private GameObject Incorrectmessage;
////	private GameObject Correctmessage;
//
//
//	// Use this for initialization
//
//	void Start (){
//		Readybutton = GameObject.Find ("Ready");
////		Incorrectmessage = GameObject.Find ("Incorrect");
////		Incorrectmessage = GameObject.Find ("Correct");
//		Instructions = GameObject.Find ("Instructions");
//		Scale = GameObject.Find ("Scale");
//	}
//
//	public void ActivateObjects () {
//
//
//			Readybutton.SetActive(true);	
//			Instructions.SetActive (true);
//			
//			Scale.transform.rotation = Quaternion.identity;
//
//
////			Nextexercise.SetActive (false);
////			Incorrectmessage.SetActive(false);
////			Correctmessage.SetActive (false);
//	
//	}
//	
//
//}

using UnityEngine;
using System.Collections;

public class Restartscene : MonoBehaviour {
	
	private GameObject Readybutton;
	private GameObject Instructions;
	private GameObject Scale;
	
	GameObject CubeRed1; 
	GameObject CubeRed2; 
	//GameObject CubeRed3; 
	//GameObject CubeRed4; 
	
	GameObject CubeYellow1; 
	GameObject CubeYellow2; 
	//GameObject CubeYellow3; 
	//GameObject CubeYellow4; 

	public Transform initialParent;

	
	static public Vector3 OriginalPosCubeRed1;
	static public Vector3 OriginalPosCubeRed2;
	//static public Vector3 OriginalPosCubeRed3;
	//static public Vector3 OriginalPosCubeRed4;
	
	static public Vector3 OriginalPosCubeYellow1;
	static public Vector3 OriginalPosCubeYellow2;
	//static public Vector3 OriginalPosCubeYellow3;
	//static public Vector3 OriginalPosCubeYellow4;

	//private Animate correctLog; 
	
	//	private GameObject Nextexercise;
	//	private GameObject Incorrectmessage;
	//	private GameObject Correctmessage;
	
	
	// Use this for initialization
	
	void Start (){

		 
		Readybutton = GameObject.Find ("Ready");
		//		Incorrectmessage = GameObject.Find ("Incorrect");
		//		Incorrectmessage = GameObject.Find ("Correct");
		Instructions = GameObject.Find ("Instructions");
		Scale = GameObject.Find ("Scale");
		
		CubeRed1 = GameObject.Find ("RedWeightLeft 1");
		CubeRed2 = GameObject.Find ("RedWeightLeft 2");
		//CubeRed3 = GameObject.Find ("RedWeightLeft 3");
		//CubeRed4 = GameObject.Find ("RedWeightLeft 4");
		
		CubeYellow1 = GameObject.Find ("YellowWeightLeft 1");
		CubeYellow2 = GameObject.Find ("YellowWeightLeft 2");
		//CubeYellow3 = GameObject.Find ("YellowWeightLeft 3");
		//CubeYellow4 = GameObject.Find ("YellowWeightLeft 4");


		OriginalPosCubeRed1 = CubeRed1.transform.position;
		OriginalPosCubeRed2 = CubeRed2.transform.position;
		//OriginalPosCubeRed3 = CubeRed3.transform.position;
		//OriginalPosCubeRed4 = CubeRed4.transform.position;			
		
		OriginalPosCubeYellow1 = CubeYellow1.transform.position;
		OriginalPosCubeYellow2 = CubeYellow2.transform.position;
		//OriginalPosCubeYellow3 = CubeYellow3.transform.position;
		//OriginalPosCubeYellow4 = CubeYellow4.transform.position;		//Or a.GetComponent<Transform>().position with your way

		//correctLog = gameObject.GetComponent<Animate> ();

	}
	
	public void ActivateObjects () {
		
	

		Readybutton.SetActive(true);	
		Instructions.SetActive (true);
		Scale.transform.rotation = Quaternion.identity;

		// Return weights to their original position

		CubeRed1.transform.position = OriginalPosCubeRed1;
		CubeRed2.transform.position = OriginalPosCubeRed2;
		//CubeRed3.transform.position = OriginalPosCubeRed3;
		//CubeRed4.transform.position = OriginalPosCubeRed4;
		
		CubeYellow1.transform.position = OriginalPosCubeYellow1;
		CubeYellow2.transform.position = OriginalPosCubeYellow2;
		//CubeYellow3.transform.position = OriginalPosCubeYellow3;
		//CubeYellow4.transform.position = OriginalPosCubeYellow4;

		// Change weight parents again

		CubeRed1.transform.parent = initialParent;
		CubeRed2.transform.parent = initialParent;
		//CubeRed3.transform.parent = initialParent;
		//CubeRed4.transform.parent = initialParent;
		
		CubeYellow1.transform.parent = initialParent;
		CubeYellow2.transform.parent = initialParent;
		//CubeYellow3.transform.parent = initialParent;
		//CubeYellow4.transform.parent = initialParent;

		//correctLog.correctToLog = 0; 


		
	}
	
	
}