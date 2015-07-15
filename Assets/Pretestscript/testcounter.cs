using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System;
using System.Threading;

public class testcounter : MonoBehaviour {
	
	DateTime startTime;
	DateTime actualTime;
	
	public GameObject Cubes;
	string counterMode;
	public GameObject Instructions;
	public GameObject performance;
	public GameObject question;
	
	
	int maxtime;
	
	public TimeSpan passedTime;
	public int pass = 0;
	
	public GameObject Next;

	void Start(){

	}
	
		
	public void startpretest () {

		
		startTime = System.DateTime.Now;
		maxtime = 7;
	
		counterMode = "starts";
	}

	// Update is called once per frame
	void Update () {

		if (counterMode == "starts") {

		
			actualTime = System.DateTime.Now;
		
			passedTime = actualTime.Subtract (startTime);
			pass = passedTime.Seconds;
			GameObject.Find ("Counter").GetComponent<showcounter> ().startcounter = true;
		
			if (passedTime.Seconds > maxtime) {
				counterMode = "stop";
				GameObject.Find ("Counter").GetComponent<showcounter> ().startcounter = false;
				gameObject.GetComponent<checkifcorrect> ().checkcorrect ();
				gameObject.GetComponent<randomexercise> ().chooseexercise ();
				GameObject.Find ("Choose").SetActive(false);
				GameObject.Find ("Plane").SetActive(false);
				GameObject.Find ("TaskQuestion").SetActive(false);

				performance.SetActive(true);
				question.SetActive(true);

				//GameObject.Find ("TaskQuestion").SetActive(true);

				//GameObject.Find ("Plane").GetComponent<changeimage> ().image ();
				//GameObject.Find ("Counter").GetComponent<showcounter> ().startcounter = true;


			

			}

		}
	}
	public void stopcounter(){
		counterMode = "stop";
	}

}
