using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Capturetextdata : MonoBehaviour {

	Text participantNumberInput;
	public string participantNumber;

	// Use this for initialization
	void Start () {


		participantNumberInput = GetComponent <Text> ();

	
	}
	
	// Update is called once per frame
	public void SaveParticipantNumber () {

		participantNumber = participantNumberInput.text;
	
	}
}
