using UnityEngine;
using System.Collections;

public class ToogleOptions : MonoBehaviour {

	public bool ActiveAugmentedReality = false;
	public bool ActiveHiddenStates = false;
	public bool ActiveAdaptiveDificulty = false;
	public bool ActiveAdaptiveLevels = false;
	public int condition = 0;
	//public int HS;
	//public int AD; 

	// Use this for initialization


	void Start(){

		DontDestroyOnLoad (transform.gameObject);
//		AR = 0;
//		HS = 0; 
//		AD = 0; 
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
		condition = 1;
	}
	public void ActiveAD () {
		if (ActiveAdaptiveDificulty == false) {
			ActiveAdaptiveDificulty = true;
		} else {
			ActiveAdaptiveDificulty = false;
		}

		condition = 2; 
	}
	public void ActiveAL () {
		if (ActiveAdaptiveLevels == false) {
			ActiveAdaptiveLevels = true;
		} else {
			ActiveAdaptiveLevels = false;
		}
		condition = 3; 
	}
	
}
