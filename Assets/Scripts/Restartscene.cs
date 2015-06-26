 using UnityEngine;
using System.Collections;

public class Restartscene : MonoBehaviour {
	
	private GameObject Readybutton;
	private GameObject Instructions;
	private GameObject Scale;
	

	void Start (){

		 
		Readybutton = GameObject.Find ("Ready");
		Instructions = GameObject.Find ("Instructions");
		Scale = GameObject.Find ("Scale");

	}
	
	public void ActivateObjects () {
		
	

		//Readybutton.SetActive(true);	
		Instructions.SetActive (true);
		Scale.transform.rotation = Quaternion.identity;


	}
	
	
}
