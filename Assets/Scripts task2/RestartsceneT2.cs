using UnityEngine;
using System.Collections;

public class RestartsceneT2 : MonoBehaviour {
	
	private GameObject Readybutton;
	private GameObject Instructions;
	private GameObject Scale;
	
	GameObject CubeRed1; 
	GameObject CubeRed2; 
	GameObject CubeRed3; 
	GameObject CubeRed4; 
	
	GameObject CubeYellow1; 
	GameObject CubeYellow2; 
	GameObject CubeYellow3; 
	GameObject CubeYellow4; 

	public Transform initialParent;

	
	static public Vector3 OriginalPosCubeRed1;
	static public Vector3 OriginalPosCubeRed2;
	static public Vector3 OriginalPosCubeRed3;
	static public Vector3 OriginalPosCubeRed4;
	
	static public Vector3 OriginalPosCubeYellow1;
	static public Vector3 OriginalPosCubeYellow2;
	static public Vector3 OriginalPosCubeYellow3;
	static public Vector3 OriginalPosCubeYellow4;
	
	
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

		
		CubeYellow1 = GameObject.Find ("YellowWeightLeft 1");
		CubeYellow2 = GameObject.Find ("YellowWeightLeft 2");


		OriginalPosCubeRed1 = CubeRed1.transform.position;
		OriginalPosCubeRed2 = CubeRed2.transform.position;
				
		
		OriginalPosCubeYellow1 = CubeYellow1.transform.position;
		OriginalPosCubeYellow2 = CubeYellow2.transform.position;
		//Or a.GetComponent<Transform>().position with your way
		
	}
	
	public void ActivateObjects () {
	
		Scale.transform.rotation = Quaternion.identity;

		// Return weights to their original position

		CubeRed1.transform.position = OriginalPosCubeRed1;
		CubeRed2.transform.position = OriginalPosCubeRed2;

		
		CubeYellow1.transform.position = OriginalPosCubeYellow1;
		CubeYellow2.transform.position = OriginalPosCubeYellow2;

		// Change weight parents again

		CubeRed1.transform.parent = initialParent;
		CubeRed2.transform.parent = initialParent;

		
		CubeYellow1.transform.parent = initialParent;
		CubeYellow2.transform.parent = initialParent;


		
	}
	
	
}
