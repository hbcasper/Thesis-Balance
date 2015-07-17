using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class showcounter : MonoBehaviour {

	Text counter;
	int lefttime;
	public bool startcounter = false;
	GameObject counterobject;
	

	testcounter TimeCounter;
	
	
	// Use this for initialization
	void Start () {
		counter = GetComponent <Text> ();

		counterobject = GameObject.Find ("testmanager");
		
		TimeCounter = counterobject.GetComponent<testcounter> ();
		
	}
	
	// Update is called once per frame
	public void Update () {
		
		if (startcounter == true) {

			lefttime = 7 - TimeCounter.pass;


		
			counter.text = "00:0" + lefttime.ToString ();
		}
		
	}
}

