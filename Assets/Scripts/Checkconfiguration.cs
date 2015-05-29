using UnityEngine;
using System;
using System.Collections;

public class Checkconfiguration : MonoBehaviour {

	private ToogleOptions GameConfiguration;
	private GameObject GameConfigurationToogles;
	private GameObject[] enviroment;
	private GameObject[] redweights;
	private GameObject[] yellowweights;
	private GameObject[] ARobjects;
	private GameObject scale;
	private GameObject normalcamera;
	public TransformParent scaleparent;
	public TransformParent indicatorlines;

	// Use this for initialization
	void Start () {
		ARobjects = GameObject.FindGameObjectsWithTag ("AR");
		
		GameConfigurationToogles = GameObject.Find ("GameConfiguration");

		try{
		GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
		

		//checar variable que viene desde el toogle

		if (GameConfiguration.ActiveAugmentedReality == true) {
			AugmentedReality ();
		} else {
			foreach (GameObject ARobject in ARobjects) {
				ARobject.SetActive (true);
			}
		}

		if (GameConfiguration.ActiveHiddenStates == true) {
			HiddenStates();
		}
		if (GameConfiguration.ActiveAdaptiveDificulty == true) {
		 AdaptiveDifficulty();
		}
		} catch (Exception e){

		}
	}
	
	void AugmentedReality(){

		enviroment = GameObject.FindGameObjectsWithTag ("Enviroment");
		redweights = GameObject.FindGameObjectsWithTag ("Red");
		yellowweights = GameObject.FindGameObjectsWithTag ("Yellow");
		scale = GameObject.Find ("Scale");
		normalcamera = GameObject.Find ("Main Camera");

		foreach (GameObject enviromentobject in enviroment)
		{
			enviromentobject.SetActive(false);
		}
		foreach (GameObject redweight in redweights)
		{
			redweight.GetComponent<Renderer> ().enabled = false;
		}
		foreach (GameObject yellowweight in yellowweights)
		{
			yellowweight.GetComponent<Renderer> ().enabled = false;
		}

		scale.GetComponent<Renderer> ().enabled = false;
		scaleparent.Changeparentfull ();
		indicatorlines.Changeparentfull ();
		normalcamera.SetActive(false);



	}
	void HiddenStates(){
		Debug.Log ("HS");
	}
	void AdaptiveDifficulty(){
		Debug.Log ("AD");
	}
}
