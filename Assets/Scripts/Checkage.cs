using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Checkage : MonoBehaviour {

	Text introducedage;
	private GameObject wrongage;
	string previousText = null;
	bool letter;
	public bool ageisset;
	public string participantAge;

	// Use this for initialization
	void Start () {
		introducedage = GetComponent <Text> ();
		wrongage = GameObject.Find ("Wrongage");
	}

	// Update is called once per frame
	void Update () {

		checkifisaletter ();

		if ((introducedage.text.Length < 3) && (introducedage.text.Length > 0) && (letter == false)) 
		{ 
					wrongage.SetActive (false);
					ageisset = true;
					participantAge = introducedage.text;
		}
		else
		{
			wrongage.SetActive (true);
			ageisset = false;
		}
	}

	void checkifisaletter()
	{
		 
		for (int i = 0; i <introducedage.text.Length; i++) {

			if (introducedage.text [i] < '0' || introducedage.text [i] > '9') {
				letter = true;
			}
			else 
			{
				letter = false;
			}
		}

	}
}



