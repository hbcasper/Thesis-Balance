using UnityEngine;
using System.Collections;

public class Userfinaldata : MonoBehaviour {

	public string participantAge;


	public string participantGender;


	GameObject participantageobject;
	Checkage participantage;

	void Start(){
		
		DontDestroyOnLoad (transform.gameObject);
	}


	public void SetGenderfemenine(){

			participantGender = "femenine";

		}

	public void SetGendermasculine(){
		participantGender = "masculine";
	}


	public void printfinaldata()			

	{
		participantageobject = GameObject.Find ("Agetext");
		participantage = participantageobject.GetComponent<Checkage> ();
		participantAge = participantage.participantAge;

	}
}
