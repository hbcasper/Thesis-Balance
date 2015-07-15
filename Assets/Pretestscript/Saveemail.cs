using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Saveemail : MonoBehaviour {

	Text input;
	public string email;


	// Use this for initialization
	void Start () {

		input = gameObject.GetComponent<Text> ();


	}
	
	// Update is called once per frame
	void Update () {

		email = input.text;
	
	}
}
