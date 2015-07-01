using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System;
using System.Threading;

public class Counter : MonoBehaviour {

	DateTime startTime;
	DateTime actualTime;

	public GameObject Cubes;
	string counterMode;
	public GameObject Instructions;


	int maxtime;

	public TimeSpan passedTime;

	public GameObject Next;

	void Start(){



	}

	public void scalemoves () {
		
		startTime = System.DateTime.Now;
		maxtime = 3;
		
		counterMode = "scalemoves";
		
	}

	public void scalegoback () {
		
		startTime = System.DateTime.Now;
		maxtime = 3;
		
		counterMode = "scalegoback";
		
	}
	// Update is called once per frame
	void Update () {
		
		actualTime = System.DateTime.Now;
		
		passedTime = actualTime.Subtract (startTime);

		if (passedTime.Seconds > maxtime) {

			if (counterMode == "scalemoves"){
				Next.SetActive(true);
				counterMode = "none";

			}
			if (counterMode == "scalegoback"){
				gameObject.GetComponent<Restartscene>().ActivateObjects();
				Cubes.SetActive(true);
				Cubes.GetComponent<ColorcubesAD>().DeactiveCubesAD();
				Cubes.GetComponent<RegisterActiveCubes>().erasecubes();
				Instructions.SetActive(true);
				Instructions.GetComponent<Instruction>().SetInstructions();
				counterMode = "none";





			}
}
	}
}
