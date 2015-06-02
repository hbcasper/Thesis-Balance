using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Checkage : MonoBehaviour {

	Text introducedage;
	Transform startbutton;

	// Use this for initialization
	void Start () {
		introducedage = GetComponent <Text> ();
		startbutton = GameObject.Find ("Startexperiment");

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void checkage (){

		if(introducedage.text == "1"){
			startbutton.GetComponent<Button>().interactable = false; 
		}

}
