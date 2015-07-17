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

	private AudioSource source;

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



		//taskcounter();
	}


	// Update is called once per frame
	void Update () {

		actualTime = System.DateTime.Now;

		passedTime = actualTime.Subtract (startTime);

		if (passedTime.Seconds > maxtime) {

			if (counterMode == "balance"){
				Next.SetActive(true);
				counterMode = "none";
			
					}
				}

			}

	public void answered(){
		Scale.SetActive (true);
		Fulcrum.SetActive (true);
		//Question.SetActive (false);
		Scale.GetComponent<Animate> ().compare ();
		
		Correct.SetActive (true);
		
		Choosebuttons.SetActive (false);

		Scale.GetComponent<Animate>().animate();
		
		
		GameObject.Find("Invisible Spaces").GetComponent<Registeractivecubes>().Checkcubes();
		GameObject.Find("Invisible Spaces").GetComponent<ColorcubesAD>().CalculateWeight();
		Log.write();

		startTime = System.DateTime.Now;
		maxtime = 1;
		counterMode = "balance";


	}



		
		}
	
	

