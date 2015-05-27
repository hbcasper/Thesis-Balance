using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Desactivebutton : MonoBehaviour {

	public Transform button;

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
	}
	
	
	// Update is called once per frame
	void Update () {
	
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
