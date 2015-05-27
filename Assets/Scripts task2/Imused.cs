using UnityEngine;
using System.Collections;

public class Imused : MonoBehaviour {
	
	//Hay que relacionarlo con algun peso y hacer algun trigger de la funcion de abajo 
	
	public int Inside = 0;
	public string Imin;
	public string side;
	public string colorimin;
	public string placeimin;
	
	
	
	public void restart ()
	{
		Inside=0;
		Imin = "none";
		side = "none";
		colorimin = "none";
		placeimin = "none";
	}
	
	void Update (){
		if(Imin.EndsWith("1")){
			placeimin = "1";
		}
		else if (Imin.EndsWith("2")){
			placeimin = "2";
		}
		else if (Imin.EndsWith("3")){
			placeimin = "3";
		}
		else if (Imin.EndsWith("4")){
			placeimin = "4";
		}
		
		else if (Imin.EndsWith("4")){
			placeimin = "4";
		}
		else if (Imin.EndsWith("5")){
			placeimin = "5";
		}
		else if (Imin.EndsWith("6")){
			placeimin = "6";
		}
		else { placeimin = "none";}
		
	}
	
	
	void OnTriggerEnter (Collider other){	
		
		Inside = 1;	
		Imin = other.name;
		side = other.tag;
		
		if (other.gameObject.GetComponent<Renderer> ().material.color == Color.red) {
			colorimin = "Red";
		}
		else if (other.gameObject.GetComponent<Renderer> ().material.color == Color.yellow) {
			colorimin = "Yellow";
		}
		
		
	}
	
	void OnTriggerStay (Collider other){ 
		
		
		Inside=1;
		Imin = other.name;
		side = other.tag;
		if (other.gameObject.GetComponent<Renderer> ().material.color == Color.red) {
			colorimin = "Red";
		}
		else if (other.gameObject.GetComponent<Renderer> ().material.color == Color.yellow) {
			colorimin = "Yellow";
		}
		
		
	}
	
	public void OnTriggerExit (Collider other){
		Inside=0;
		Imin = "none";
		side = "none";
		colorimin = "none";
	}
	
	//public void Weightactive { 
	// funcion aplica si el peso relacionado se pone!
	
	//Inside=1;
	// Imin = nombredelcuboenelqueseposiciono;
	//side = ladoenelqueesta;
	//}
	
	//public void Weightunactive{
	// funcion aplica si el peso relacionado se quita!
	
	
	//Inside=0;
	// Imin = nombredelcuboenelqueseposiciono;
	//side = ladoenelqueesta;
	
	//}
	
	
}