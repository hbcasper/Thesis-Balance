using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System;

public class Counter : MonoBehaviour {

	DateTime startTime;
	DateTime actualTime;

	int maxtime;

	public string counterMode;

	public TimeSpan passedTime;

	public GameObject Scale;
	public GameObject Fulcrum;
	public GameObject Choosebuttons;
	public GameObject Next;
	public GameObject Question;
	public GameObject Correct;
	public GameObject Incorrect;


	Animate Scaledata;

	Textfile Log;


	void Start(){
		counterMode = "none";

	
		Log = gameObject.GetComponent<Textfile> ();



		taskcounter();
	}

	// Use this for initialization
	public void taskcounter () {

		startTime = System.DateTime.Now;
		maxtime = 4;

		counterMode = "scale";
	
	}
	void answercounter () {
		
		startTime = System.DateTime.Now;
		maxtime = 3;
		
		counterMode = "ask";
		
	}
	
	// Update is called once per frame
	void Update () {

		actualTime = System.DateTime.Now;

		passedTime = actualTime.Subtract (startTime);

		if (passedTime.Seconds > maxtime) {

			if (counterMode == "scale"){
				Debug.Log ("maxscaletime");
				Scale.SetActive(false);
				Fulcrum.SetActive(false);
				Choosebuttons.SetActive(true);
				answercounter();
				Question.SetActive(true);

			}
			else if (counterMode == "ask"){
				Debug.Log ("maxasktime");
			
				Scale.SetActive(true);
				Fulcrum.SetActive(true);
				Scale.GetComponent<Animate>().animate();
				Scale.GetComponent<Animate>().whichbutton = 3;
				Scale.GetComponent<Animate>().compare();
				Next.SetActive(true);
				Correct.SetActive(true);
				Incorrect.SetActive(true);
				Choosebuttons.SetActive(false);
				Log.StoreEndTime();
				Log.write();
				Question.SetActive(false);


				counterMode = "none";
				//Animate.animate();

			}
		
		}
	
	}
}
