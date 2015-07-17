using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Selectedtoogle : MonoBehaviour {

	public string selectedOption;
	Text Option;
	bool toogle;
	Toggle options;


	void Start(){
			options = GetComponent<Toggle> ();

	}

	// Update is called once per frame
	void Update () {

		if (options.isOn) {
			Option = GetComponentInChildren<Text> ();
			selectedOption = Option.text;
	

		} else {
			selectedOption = null;
	
		}

	
	}
}
