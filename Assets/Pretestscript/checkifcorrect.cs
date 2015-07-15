using UnityEngine;
using System.Collections;

public class checkifcorrect : MonoBehaviour {


	randomexercise exercisenumber;
	public string exercise;
	string scene;
	public string correctanswer;
	public int answer;
	public string pressed;
	public string answerlog;
	public int count;
	public string exerciselog;
	public string performance;
	public int trials;
	// Use this for initialization
	void Start () {

		trials = 0;

	
		exercisenumber = gameObject.GetComponent<randomexercise> ();
	
	}
	void Update(){
		scene = Application.loadedLevelName;
	}

	
	// Update is called once per frame
	public void correctanwsers () {

		exercise = exercisenumber.exercise;
		exerciselog = exerciselog + exercise + ",";

		if (scene == "Pretesthotair") {
			if (exercise == "1") {
				correctanswer = "5";
			} else if (exercise == "2") {
				correctanswer = "1";
			} else if (exercise == "3") {
				correctanswer = "10";
			} else if (exercise == "4") {
				correctanswer = "12";
			} else if (exercise == "5") {
				correctanswer = "3";
			}
		}
			else if (scene == "Pretestscale") {
				if (exercise == "1") {
					correctanswer = "Right";
				} else if (exercise == "2") {
					correctanswer = "Left";
				} else if (exercise == "3") {
					correctanswer = "Left";
				} else if (exercise == "4") {
					correctanswer = "Right";
				} else if (exercise == "5") {
					correctanswer = "Left";
				}
		}
		else if (scene == "Posttesthotair") {
			if (exercise == "1") {
				correctanswer = "5";
			} else if (exercise == "2") {
				correctanswer = "9";
			} else if (exercise == "3") {
				correctanswer = "8";
			} else if (exercise == "4") {
				correctanswer = "4";
			} else if (exercise == "5") {
				correctanswer = "7";
			}
		}
		else if (scene == "Posttestscale") {
			if (exercise == "1") {
				correctanswer = "Right";
			} else if (exercise == "2") {
				correctanswer = "Left";
			} else if (exercise == "3") {
				correctanswer = "Left";
			} else if (exercise == "4") {
				correctanswer = "Left";
			} else if (exercise == "5") {
				correctanswer = "Left";
			}
		}
	}

		public void checkcorrect(){
		correctanwsers ();

		if (pressed == correctanswer) {

			answer = 1;
		} else {
			answer = 0;
		}
		correctcount ();
		pressed = "0";

		}

	void correctcount(){
		answerlog = answerlog + answer.ToString() + ",";
		count = count + answer;
		Debug.Log ("correct count" +count);
		Debug.Log ("answerlog"+answerlog);

	}
	public void performanceanswer(){


		performance = performance + pressed + ",";
		Debug.Log ("performance"+performance);
		
		trials = trials +1;
		Debug.Log ("trials"+trials);
		//Debug.Log (trials);
		
		if (trials >4) {
				
			GameObject.Find("userdata").GetComponent<userdata>().savetestdata();


			if (scene == "Pretesthotair") {

			Application.LoadLevel("Pretestscale");
				}
			else if (scene == "Pretestscale") {
				Application.LoadLevel("UserInstuction");
				}
			else if (scene == "Posttesthotair") {
				Application.LoadLevel("Posttestscale");
			}
			else if (scene == "Posttestscale") {
				Application.LoadLevel("PostQuestionnaire");
			}
		}
		
	}
	
	
}

