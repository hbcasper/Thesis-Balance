using UnityEngine;
using System.Collections;

public class Answerresult : MonoBehaviour {

	private Animate Result;
	public GameObject Objet;

	// Use this for initialization
	void Start ()
	{
		Result = Objet.GetComponent<Animate> ();
	}

	// Update is called once per frame
	public void Update () 
	{

		if (gameObject.name == "Correct" && Result.correct == 0)
			{ 
				gameObject.SetActive(false);
			}

		if (gameObject.name == "Incorrect" && Result.correct == 1)
			{
				gameObject.SetActive(false);
			}


		
	}
}
