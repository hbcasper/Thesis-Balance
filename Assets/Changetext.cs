using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Changetext : MonoBehaviour {

	Text instruction;
	public string correctanswer;


	private Animate Result;
	public GameObject Objet;
	public GameObject nextbutton;

	float timer = 0;
	float starttime;
	float maxtimer = 3;

	void Start (){
		Result = Objet.GetComponent<Animate> ();
		instruction = GetComponent <Text> ();
		
	}


	public void WTF(){



		if (Result.correct == 1) {
			correctanswer = "correct";
		} else {
			correctanswer = "incorrect";
		}
				
		instruction.text= "Press the boton 'Start' in the physical balance";

		yield return new WaitForSeconds (3.0f);

		instruction.text="Your answer is " + correctanswer;

		if (correctanswer == "correct") {
			instruction.color = Color.green;
		} else {
			instruction.color = Color.red;
		}

		yield return new WaitForSeconds (3.0f);
		instruction.color = Color.black;
		instruction.text="Press the'Start' button";

		yield return new WaitForSeconds (3.0f);

		nextbutton.SetActive (true);
		gameObject.SetActive (false);

	}




}



	


