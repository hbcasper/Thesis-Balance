using UnityEngine;
using System.Collections;

public class ToogleOptions : MonoBehaviour {
	
	public bool ActiveAugmentedReality;
	//public bool ActiveHiddenStates = false;
	public bool ActiveAdaptiveDificulty = false;
	public bool ActiveAdaptiveLevels = false;
	public bool Data = false;
	public int condition = 0;
	//public string participantnumber;
	//public GameObject ParticipantNumberText;
	//public int HS;
	//public int AD; 
	
	// Use this for initialization
	
	
	void Start(){
		ActiveAugmentedReality = false;
		
		DontDestroyOnLoad (transform.gameObject);
	}
	
	public void ActiveAD () {
		if (ActiveAdaptiveDificulty == false) {
			ActiveAdaptiveDificulty = true;
			condition = 1; 
		} else {
			ActiveAdaptiveDificulty = false;
			condition = 2; 
			
		}
		
		
	}
	public void SaveData () {
		if (Data == false) {
			Data = true;
		} else {
			Data = false;
		}
		
		
	}
	public void ActiveAL () {
		if (ActiveAdaptiveLevels == false) {
			ActiveAdaptiveLevels = true;
		} else {
			ActiveAdaptiveLevels = false;
		}
		
	}
	//	public void storeparticipant(){
	//
	//		Text participantText = ParticipantNumberText.GetComponent<Text>();
	//
	//
	//		participantnumber = participantText.text;
	//	}
	
}