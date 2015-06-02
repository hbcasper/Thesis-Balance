using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Activeunactiveinteractivity : MonoBehaviour {

	private GameObject Checkage;
	private Checkage agescript;
	private bool genderisset;

	void Start(){

		gameObject.GetComponent<Button> ().interactable = false;

		Checkage = GameObject.Find ("Agetext");
		agescript = Checkage.GetComponent<Checkage>();

	}

	public void genderset(){
		genderisset = true;
	}


	void Update () {

		if ((agescript.ageisset == true) && (genderisset == true)){

		gameObject.GetComponent<Button> ().interactable = true;
		}


	
	}
}
