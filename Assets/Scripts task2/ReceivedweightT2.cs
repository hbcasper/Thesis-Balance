using UnityEngine;
using System.Collections;

public class ReceivedweightT2 : MonoBehaviour {

	public int Cubereceives = 0;
	public int Cubereceivesweight = 0;
	public int Imthecubenumber;

	void OnTriggerEnter (Collider other)

	{
			
		if (other.gameObject.tag == "yellow") {
			Cubereceivesweight = 2;
		}
		else if (other.gameObject.tag == "red"){
			Cubereceivesweight = 1;

		}

			
	}
	void OnTriggerStay (Collider other)
		
		
	{
		
		if (other.gameObject.tag == "Yellow") {
			Cubereceivesweight = 2;
		}
		else if (other.gameObject.tag == "Red"){
			Cubereceivesweight = 1;
			
		}

		
	}

	void OnTriggerExit (Collider other)
		
	{
		
		Cubereceives = 0;
		Cubereceivesweight = 0;
		
	}

	void Update (){
	
		if (gameObject.name == "LeftCube1" || gameObject.name == "RightCube1"){
			Imthecubenumber = 1;
		}
		else if (gameObject.name == "LeftCube2" || gameObject.name == "RightCube2") {
			Imthecubenumber = 2;
		}
		else if (gameObject.name == "LeftCube3" || gameObject.name == "RightCube3") {
			Imthecubenumber = 3;
		}
		else if (gameObject.name == "LeftCube4" || gameObject.name == "RightCube4") {
			Imthecubenumber = 4;
		}
		else if (gameObject.name == "LeftCube5" || gameObject.name == "RightCube5") {
			Imthecubenumber = 5;
		}
		else if (gameObject.name == "LeftCube6" || gameObject.name == "RightCube6") {
			Imthecubenumber = 6;
		}
	}
}
