using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Capturetextdata : MonoBehaviour {

	Text participantNumberInput;
	public string participantNumber;
	public GameObject Set;
	bool letter;


	// Use this for initialization
	void Start () {


		participantNumberInput = GetComponent <Text> ();
	
		Set = GameObject.Find ("Set");
	
	}
	
	// Update is called once per frame
	public void SaveParticipantNumber () {

		participantNumber = participantNumberInput.text;
	
	}

	void Update (){

		checkifisaletter ();

		if (participantNumberInput != null) {

			if ((participantNumberInput.text.Length > 0) && (letter != true)) {
				Set.GetComponent<Button> ().interactable = true;
			} else {
				Set.GetComponent<Button> ().interactable = false;
			}
		}

	}


	
	void checkifisaletter()
	{
		if (participantNumberInput != null) {
			for (int i = 0; i <participantNumberInput.text.Length; i++) {
			
				if (participantNumberInput.text [i] < '0' || participantNumberInput.text [i] > '9') {
					letter = true;
				} else {
					letter = false;
				}
			}
		}
	}

}
