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
	public TransformParent indicatorlines;
	GameObject[] HiddenStatesObjects;
	GameObject[] AdaptiveDifficultyObjects;
	GameObject ReactiveSystemNext;
	private InputOutputADS ActiveADSystem;

	// Use this for initialization
	void Start () {
		ARobjects = GameObject.FindGameObjectsWithTag ("AR");
		GameConfigurationToogles = GameObject.Find ("GameConfiguration");
		HiddenStatesObjects = GameObject.FindGameObjectsWithTag ("HiddenStates");
		AdaptiveDifficultyObjects = GameObject.FindGameObjectsWithTag ("AD");
		ReactiveSystemNext = GameObject.Find ("Next");
		ActiveADSystem = gameObject.GetComponent<InputOutputADS>();

		try{

		GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
		//check AR
		if (GameConfiguration.ActiveAugmentedReality == true) 
			{
			
			} else 
			{
			foreach (GameObject ARobject in ARobjects) 
				{
				ARobject.SetActive (false);
				}
			}
		
			//check HS

		if (GameConfiguration.ActiveHiddenStates == false) 
			
			{	foreach (GameObject HiddenStateObject in HiddenStatesObjects) 
				{
					HiddenStateObject.SetActive(false);
				}

				}

		//check AD
		if (GameConfiguration.ActiveAdaptiveDificulty == true) 
		{
		
				AdaptiveDifficulty();

			}
		if (GameConfiguration.ActiveAdaptiveLevels == true) 
		{
			AdaptiveLevels();
		}
//			else
//			{
//				foreach (GameObject AdaptiveDifficultyObject in AdaptiveDifficultyObjects) 
//				{
//					AdaptiveDifficultyObject.SetActive(false);
//				}
//			}
		} catch (Exception e){}
	}

	



	void AdaptiveLevels(){
		
		//ActiveADSystem.DeclareParameters ();
	}

	void AdaptiveDifficulty(){

		ActiveADSystem.DeclareParameters();

	}
}
