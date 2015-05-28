using UnityEngine;
using System.Collections;

public class ToogleOptions : MonoBehaviour {

	public bool ActiveAugmentedReality = false;
	public bool ActiveHiddenStates = false;
	public bool ActiveAdaptiveDificulty = false;

	// Use this for initialization


	void Start(){

		DontDestroyOnLoad (transform.gameObject);
	}

	public void ActiveAR(){
		ActiveAugmentedReality = true;
	}
	public void ActiveHS (){
		ActiveHiddenStates = true;
	}
	public void ActiveAD () {
		ActiveAdaptiveDificulty = true;
	}
	
}
