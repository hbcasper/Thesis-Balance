using UnityEngine;
using System.Collections;

public class ToogleOptions : MonoBehaviour {

public bool ActiveAugmentedReality = false;
public bool ActiveHiddenStates = false;
	public bool ActiveAdaptiveDificulty = false;
public bool ActiveAdaptiveLevels = false;
	public int condition;

	public GameObject uData;
	Capturetextdata userdata;
	public string participantNumber;
	//public int HS;
	//public int AD; 

	// Use this for initialization


	void Start(){

		DontDestroyOnLoad (transform.gameObject);
		userdata = uData.GetComponent<Capturetextdata> ();
		condition = 1;
//		AR = 0;
//		HS = 0; 
//		AD = 0; 

	}

	public void saveuserdata(){
		participantNumber = userdata.participantNumber;


	}

	public void ActiveAR(){
		if (ActiveAugmentedReality == true) {
			ActiveAugmentedReality = false;
		} else {
			ActiveAugmentedReality = true;
		}
	}
	public void ActiveHS (){
		if (ActiveHiddenStates == false) {
			ActiveHiddenStates = true;
		} else {
			ActiveHiddenStates = false;
		}

	}
	public void ActiveAD () {
		if (ActiveAdaptiveDificulty == false) {
			ActiveAdaptiveDificulty = true;
			condition = 2;
		} else {
			ActiveAdaptiveDificulty = false;
			condition = 1;

		}
	}


	public void ActiveAL () {
		if (ActiveAdaptiveLevels == false) {
			ActiveAdaptiveLevels = true;
		} else {
			ActiveAdaptiveLevels = false;
		}
		 
	}
	
}
