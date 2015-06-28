using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System;
using System.Threading;


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
		Log.StoreReadyTime ();
		
		counterMode = "ask";
		
	}
	void balancecounter(){
		startTime = System.DateTime.Now;
		maxtime = 1;
		counterMode = "balance";
		
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
				Question.SetActive(false);
				Scale.GetComponent<Animate>().compare();
			
				Correct.SetActive(true);

				Choosebuttons.SetActive(false);
				balancecounter();
			}

			else if (counterMode == "balance"){
						
						Scale.GetComponent<Animate>().animate();

						
				if (Scale.GetComponent<Animate>().whichbutton == 3){	
					Log.StoreEndTime();
						}
				GameObject.Find("Invisible Spaces").GetComponent<Registeractivecubes>().Checkcubes();
						GameObject.Find("Invisible Spaces").GetComponent<ColorcubesAD>().CalculateWeight();
						Log.write();
						Next.SetActive(true);
						counterMode = "none";
					}
				}

			}

		
		}
	
	

