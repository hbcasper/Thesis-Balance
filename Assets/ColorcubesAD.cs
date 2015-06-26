using UnityEngine;
using System.Collections;

public class ColorcubesAD : MonoBehaviour {


	Seecubes[] activecubes;
	public int totalLeft = 0;
	public int totalRight = 0;
	public int difference;

	public void Start(){
		activecubes = gameObject.GetComponentsInChildren<Seecubes> ();
	}

	public void Update(){

		}


	public void ActiveCubesAD() {
		
		foreach (Seecubes script in activecubes) {
			
			script.ActiveCubesAD ();



		}
		CalculateWeight();
	}

		public void DeactiveCubesAD() {
		totalLeft = 0;
		totalRight = 0;
			
			foreach (Seecubes script in activecubes) {
				
				script.NoActiveCubesAD();

			}
	}

	public void CalculateWeight(){
		foreach (Seecubes script in activecubes) {
			
			if (script.gameObject.tag == ("Left")){
				totalLeft = totalLeft + script.myValue;
			}
			if (script.gameObject.tag == ("Right")){
					totalRight = totalRight + script.myValue;
	
		}

		}

			if (totalLeft > totalRight) {
			
			difference = totalLeft - totalRight;
		} else if (totalLeft < totalRight) {
			
			difference = totalRight - totalLeft;
		} else {
			difference = 0;
		}

}
}
