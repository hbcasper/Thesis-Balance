using UnityEngine;
using System.Collections;

public class Receivedweight : MonoBehaviour {

	public string Cubereceives = "Grey";

	//llamarinputsdelarduino

	void OnTriggerEnter (Collider other)

	{
			
			Cubereceives = other.gameObject.tag;
			
		}
	void OnTriggerStay (Collider other)
		
	{
		
		Cubereceives = other.gameObject.tag;
		
	}

	void OnTriggerExit (Collider other)
		
	{
		
		Cubereceives = "Grey";

	}

	//void Update {
//
//		if elpesodearduinoespuesto {
//			
//			Cubereceives = colordelpesopuestoenarduino;
//		}
//		
//		if elpesoesquitado {
//			
//			Cubereceives = "Grey";
//			
//		}
}
