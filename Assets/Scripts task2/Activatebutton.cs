using UnityEngine;
using System.Collections;

public class Activatebutton : MonoBehaviour {

	private Iscorrect Result;
	public GameObject Correctresult;

	// Use this for initialization
	void Start () {
	
		Result = Correctresult.GetComponent<Iscorrect> ();

	
	}
	
	// Update is called once per frame
	public void Update () {

		if (gameObject.name == "Correct" && Result.Correct == 0)
		{ 
			gameObject.SetActive(false);
		}
	
		
		if (gameObject.name == "Incorrect" && Result.Correct == 1)
		{
			gameObject.SetActive(false);
		}
	
	}
}
