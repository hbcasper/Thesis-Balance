using UnityEngine;
using System;
using System.Collections;

public class Checkconfiguration : MonoBehaviour {

	private ToogleOptions GameConfiguration;
	private GameObject GameConfigurationToogles;
	private GameObject[] enviroment;
	private GameObject[] redweights;
	private GameObject[] greenweights;
	private GameObject[] yellowweights;
	private GameObject[] ARobjects;
	private GameObject scale;
	private GameObject normalcamera;
	public TransformParent scaleparent;
	//public TransformParent indicatorlines;
	//GameObject[] HiddenStatesObjects;
	GameObject[] AdaptiveDifficultyObjects;
	GameObject ReactiveSystemNext;
	private InputOutputADS ActiveADSystem;

	// Use this for initialization
	void Start () {
		ARobjects = GameObject.FindGameObjectsWithTag ("AR");
		GameConfigurationToogles = GameObject.Find ("GameConfiguration");
		//HiddenStatesObjects = GameObject.FindGameObjectsWithTag ("HiddenStates");
		AdaptiveDifficultyObjects = GameObject.FindGameObjectsWithTag ("AD");
		ReactiveSystemNext = GameObject.Find ("Next");
		ActiveADSystem = gameObject.GetComponent<InputOutputADS>();

	

		GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
		//check AR
		if (GameConfiguration.ActiveAugmentedReality == true) 
			{
			AugmentedReality ();
			} else 
			{
			foreach (GameObject ARobject in ARobjects) 
				{
				ARobject.SetActive (false);
				}
			}
		
			//check HS

		//if (GameConfiguration.ActiveHiddenStates == false) 
			
			//	foreach (GameObject HiddenStateObject in HiddenStatesObjects) 
				//{
				//	HiddenStateObject.SetActive(false);
				//}

				

		//check AD
		if (GameConfiguration.ActiveAdaptiveDificulty == true) 
		{
			ActiveADSystem.SetDifficulty();

			}

		
	}

	
	void AugmentedReality(){ //AR Behavior

		enviroment = GameObject.FindGameObjectsWithTag ("Enviroment");
		redweights = GameObject.FindGameObjectsWithTag ("Red");
		yellowweights = GameObject.FindGameObjectsWithTag ("Yellow");
		greenweights = GameObject.FindGameObjectsWithTag ("Green");
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
		foreach (GameObject greenweight in greenweights)
		{
			greenweight.GetComponent<Renderer> ().enabled = false;
		}
		foreach (GameObject yellowweight in yellowweights)
		{
			yellowweight.GetComponent<Renderer> ().enabled = false;
		}

		scaleparent.Changeparentfull ();
		//indicatorlines.Changeparentfull ();
		//scale.GetComponent<Renderer> ().enabled = false;

		normalcamera.SetActive(false);
	}





}
