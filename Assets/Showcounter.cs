using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;


public class Showcounter : MonoBehaviour {

	Text counter;
	int lefttime;

	public GameObject ExerciseManager;
	Counter TimeCounter;


	// Use this for initialization
	void Start () {
		counter = GetComponent <Text> ();

		TimeCounter = ExerciseManager.GetComponent<Counter> ();
	
	}
	
	// Update is called once per frame
	void Update () {


		if (TimeCounter.counterMode == "scale"){
			lefttime = 4-TimeCounter.passedTime.Seconds;

		}
		else if (TimeCounter.counterMode == "ask"){
			lefttime = 3-TimeCounter.passedTime.Seconds;
		
		}

		counter.text="00:0"+lefttime.ToString();
	
	}
}
