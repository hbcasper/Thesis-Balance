using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Activeunactiveinteractivity : MonoBehaviour {

	private GameObject Checkage;
	private Checkage agescript;
	private bool genderisset;

	void Start(){

		gameObject.GetComponent<Button> ().interactable = false;



	}

	public void genderset(){
		genderisset = true;
	}


	void Update () {

		if (gameObject.name == ("Startexperiment")) {

			Checkage = GameObject.Find ("Agetext");
			agescript = Checkage.GetComponent<Checkage>();


			if ((agescript.ageisset == true) && (genderisset == true)) {

				gameObject.GetComponent<Button> ().interactable = true;
			} else {
				gameObject.GetComponent<Button> ().interactable = false;
			}
		}



	
	}
}
