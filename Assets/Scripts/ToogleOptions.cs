using UnityEngine;
using System.Collections;

public class ToogleOptions : MonoBehaviour {

	public bool ActiveAugmentedReality = false;
	public bool ActiveHiddenStates = false;
	public bool ActiveAdaptiveDificulty = false;
	public int condition;
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
		ActiveAugmentedReality = true;
		condition = 0;

	}
	public void ActiveHS (){
		ActiveHiddenStates = true;
		condition = 1;
	}
	public void ActiveAD () {
		ActiveAdaptiveDificulty = true;
		condition = 2; 
	}
	
}
