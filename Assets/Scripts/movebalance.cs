using UnityEngine;
using System.Collections;

public class movebalance : MonoBehaviour {

	public GameObject Scale;
	ArduinoInputBehavior ScaleResult;
	AndroidWrapper Bluetooth;


	// Use this for initialization
	void Start () {

		ScaleResult = Scale.GetComponent<ArduinoInputBehavior> ();
		Bluetooth = gameObject.GetComponent<AndroidWrapper>();
	
	}
	
	// Update is called once per frame
	public void movephysical () {

		if (ScaleResult.balance == 1) {
			Bluetooth.goLeft();
		}
	
		if (ScaleResult.balance == 2) {
			Bluetooth.goRight();

		}
	}



	
	}

