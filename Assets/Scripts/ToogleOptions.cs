using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToogleOptions : MonoBehaviour {

	public bool ActiveAugmentedReality;
	public bool ActiveHiddenStates = false;
	public bool ActiveAdaptiveDificulty = false;
	public bool ActiveAdaptiveLevels = false;
	public int condition = 0;
	public string participantnumber;
	//public int HS;
	//public int AD; 

	// Use this for initialization


	void Start(){
		ActiveAugmentedReality = true;

		DontDestroyOnLoad (transform.gameObject);
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
	public void storeparticipant(){

		Text participantText = GameObject.Find("ParticipantNumberText").GetComponent<Text>();


		participantnumber = participantText.text;
	}
	
}
