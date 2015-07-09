using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CorrectIncorrect : MonoBehaviour {
	
	private Animate Result;
	private ArduinoInputBehavior CorrectAnswer;
	GameObject Scale;
	Text Resulttext;
	public GameObject Audio;
	PlaySounds AudioFeedback;
	string answer;
	
	// Use this for initialization
	void Start () {
		Scale = GameObject.Find ("Scale");
		Result = Scale.GetComponent<Animate> ();
		Resulttext = GetComponent<Text> ();


		
		CorrectAnswer = Scale.GetComponent<ArduinoInputBehavior> ();
		
	}
	
	// Update is called once per frame
	public void Update () {
		
		if (Result.correct == 0)
		{ 
			Resulttext.color = Color.red; 
			int correctanswer = CorrectAnswer.balance;

			if (correctanswer == 0){
				answer = "Balance";
			}
			if (correctanswer == 1){
				answer = "Left";
			}
			if (correctanswer == 2){
				answer = "Right";
			}


			Resulttext.text = "Incorrect \n Correct Answer: "+answer;
		
		}
		
		if (Result.correct == 1)
		{
			Resulttext.color = Color.green; 
			Resulttext.text = "Correct";

		
		}
		

	}





}