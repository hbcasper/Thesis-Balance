using UnityEngine;
using System.Collections;

public class dissapear : MonoBehaviour {


	// Update is called once per frame
	public void Dissapear () {

		foreach(Renderer variableName in GetComponentsInChildren<Renderer>()){

			variableName.GetComponent<Renderer>().enabled = false;
		}

		}
	public void Appear () {
		
		foreach(Renderer variableName in GetComponentsInChildren<Renderer>()){
			
			if(gameObject.tag == "number"){
			variableName.GetComponent<Renderer>().enabled = true;
			}
		}
		
	}
	
	}

