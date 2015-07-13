using UnityEngine;
using System.Collections;

public class pressed : MonoBehaviour {

	string pressedbutton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Pressbutton() {

	GameObject.Find("testmanager").GetComponent<checkifcorrect>().pressed = gameObject.name;
	
	}
}
