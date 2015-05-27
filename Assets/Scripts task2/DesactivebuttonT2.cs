using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DesactivebuttonT2 : MonoBehaviour {

	public Transform button;

	//Calling cube values

	private Blockspaces Cube1result;
	public GameObject LeftCube1;

	private Blockspaces Cube2result;
	public GameObject LeftCube2;

	private Blockspaces Cube3result;
	public GameObject LeftCube3;

	private Blockspaces Cube4result;
	public GameObject LeftCube4;

	private Blockspaces Cube5result;
	public GameObject LeftCube5;

	private Blockspaces Cube6result;
	public GameObject RightCube1;

	private Blockspaces Cube7result;
	public GameObject RightCube2;

	private Blockspaces Cube8result;
	public GameObject RightCube3;

	private Blockspaces Cube9result;
	public GameObject RightCube4;

	private Blockspaces Cube10result;
	public GameObject RightCube5;

	private Blockspaces Cube11result;
	public GameObject RightCube6;

	private Blockspaces Cube12result;
	public GameObject LeftCube6;




	// Use this for initialization
	void Start () {
		Cube1result = LeftCube1.GetComponent<Blockspaces> ();
		Cube2result = LeftCube2.GetComponent<Blockspaces> ();
		Cube3result = LeftCube3.GetComponent<Blockspaces> ();
		Cube4result = LeftCube4.GetComponent<Blockspaces> ();
		Cube5result = LeftCube5.GetComponent<Blockspaces> ();
		Cube6result = RightCube1.GetComponent<Blockspaces> ();
		Cube7result = RightCube2.GetComponent<Blockspaces> ();
		Cube8result = RightCube3.GetComponent<Blockspaces> ();
		Cube9result = RightCube4.GetComponent<Blockspaces> ();
		Cube10result = RightCube5.GetComponent<Blockspaces> ();
		Cube11result = RightCube6.GetComponent<Blockspaces> ();
		Cube12result = LeftCube6.GetComponent<Blockspaces> ();
	}
	
	
	// Update is called once per frame
	void Update () {
	
		if (Cube1result.notallow == 0 && Cube2result.notallow == 0 && Cube3result.notallow == 0 
		    && Cube4result.notallow == 0 && Cube5result.notallow == 0 && Cube6result.notallow == 0 
		    && Cube7result.notallow == 0 && Cube8result.notallow == 0 && Cube9result.notallow == 0 
		    && Cube10result.notallow == 0 && Cube11result.notallow == 0 && Cube12result.notallow == 0)
		{

		button.GetComponent<Button>().interactable = true; 
	
		}

	else
		{

		button.GetComponent<Button>().interactable = false; 
		}
	}

}
