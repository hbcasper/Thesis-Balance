using UnityEngine;
using System.Collections;

public class Seecubes : MonoBehaviour {

	// private Instruction Valores; 
	private Instruction Valores;
	public GameObject Objeto;	
	public string colorName; 

	void Start (){

		gameObject.GetComponent<Collider> ().enabled = false;
		//Valores = Objeto.GetComponent<Instruction>();	
		Valores = Objeto.GetComponent<Instruction> (); 
		//gameObject.GetComponent<Renderer> ().enabled = false;
		gameObject.GetComponent<Renderer> ().material.color = Color.clear;

	}
	
    void Update () {

		int nameLenght = gameObject.name.Length;
		int cubeIsRight = 0;
		int cubeIndex = int.Parse(gameObject.name[nameLenght - 1].ToString());
		
		if (((Valores.pnr1 == cubeIndex || Valores.pnr2 == cubeIndex) && gameObject.tag == "Right")||((Valores.pnl1 == cubeIndex || Valores.pnl2 == cubeIndex) && gameObject.tag == "Left"))
		{
			gameObject.GetComponent<Collider> ().enabled = true;
			//gameObject.GetComponent<Renderer> ().enabled = true;
			//gameObject.GetComponent<Renderer> ().material.color = Color.red;
		} else {
			gameObject.GetComponent<Collider> ().enabled = false;	
			//gameObject.GetComponent<Renderer> ().enabled = false;
			gameObject.GetComponent<Renderer> ().material.color = Color.clear;
		}

		if ((Valores.pnr1 == cubeIndex) && gameObject.tag == "Right"){
			Colorchange (Valores.colorname3);
			colorName = Valores.colorname3;
		}
		else if 
		((Valores.pnr2 == cubeIndex)  && gameObject.tag == "Right"){
			Colorchange (Valores.colorname4);
			colorName = Valores.colorname4;
		}
		else if 
		((Valores.pnl1 == cubeIndex)  && gameObject.tag == "Left"){
			Colorchange (Valores.colorname1);
			colorName = Valores.colorname1;
		}
		else if 
		((Valores.pnl2 == cubeIndex) && gameObject.tag == "Left"){
			Colorchange (Valores.colorname2);
			colorName = Valores.colorname2;
		}

		GrowCube (colorName); 

	}
	void Colorchange(string color){
		
		if (color == "red") {
			gameObject.GetComponent<Renderer> ().material.color = Color.red;

		} else if (color == "yellow") {
			gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
			//gameObject.transform.localScale = new Vector3(2.0f,3.0f,0);
		} 
		
		
	}

	void GrowCube(string colorName){

	//if (Hidden States == true){
	 if (colorName == "yellow") {
			gameObject.transform.localScale = new Vector3(2f,3f,0);
		} 
		// }
	}

}
		


