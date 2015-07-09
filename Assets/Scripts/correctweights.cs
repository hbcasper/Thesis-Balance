using UnityEngine;
using System.Collections;

public class correctweights : MonoBehaviour {

	string actualConfiguration;
	GameObject GameManager;
	AndroidWrapper Bluetooth;

	// Use this for initialization
	void Start () {
		GameManager = GameObject.Find ("Exercisemanager");
		Bluetooth = GameManager.GetComponent<AndroidWrapper> ();

	
	}
	
	// Update is called once per frame
	void Update () {

		actualConfiguration = Bluetooth.configuration;
	}

	void Checkconfiguration(){

	}

}
