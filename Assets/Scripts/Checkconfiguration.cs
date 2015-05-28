using UnityEngine;
using System.Collections;

public class Checkconfiguration : MonoBehaviour {

	private ToogleOptions GameConfiguration;
	private GameObject GameConfigurationToogles;
	private GameObject[] enviroment;
	private GameObject[] redweights;
	private GameObject[] yellowweights;
	private GameObject scale;

	// Use this for initialization
	void Start () {

		GameConfigurationToogles = GameObject.Find ("GameConfiguration");

		GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();

		//checar variable que viene desde el toogle

		if (GameConfiguration.ActiveAugmentedReality == true) {
			AugmentedReality();
		}
		if (GameConfiguration.ActiveHiddenStates == true) {
			HiddenStates();
		}
		if (GameConfiguration.ActiveAdaptiveDificulty == true) {
		 AdaptiveDifficulty();
		}
	}
	
	void AugmentedReality(){

		enviroment = GameObject.FindGameObjectsWithTag ("Enviroment");
		redweights = GameObject.FindGameObjectsWithTag ("Red");
		yellowweights = GameObject.FindGameObjectsWithTag ("Yellow");
		scale = GameObject.Find ("Scale");

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


	}
	void HiddenStates(){
		Debug.Log ("HS");
	}
	void AdaptiveDifficulty(){
		Debug.Log ("AD");
	}
}
