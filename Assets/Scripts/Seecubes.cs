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
		gameObject.GetComponent<Renderer> ().enabled = false;

	}
	
    void Update () {

		//string[] cubeColors = new string[] {"red", "yellow","","","","red", "yellow","","","","red", "yellow"};
		int nameLenght = gameObject.name.Length;
	
		int cubeIsRight = 0;
		//if (gameObject.name[0] == 'R') {
		//	cubeIsRight = 1;
		//}
		//int cubeIndex = (cubeIsRight*6 + int.Parse(gameObject.name[nameLenght - 1].ToString())) - 1 ;
		int cubeIndex = int.Parse(gameObject.name[nameLenght - 1].ToString());

	


		if (((Valores.pnr1 == cubeIndex || Valores.pnr2 == cubeIndex) && gameObject.tag == "Right")||((Valores.pnl1 == cubeIndex || Valores.pnl2 == cubeIndex) && gameObject.tag == "Left"))
		{
			gameObject.GetComponent<Collider> ().enabled = true;
			gameObject.GetComponent<Renderer> ().enabled = true;
		} else {
			gameObject.GetComponent<Collider> ().enabled = false;
			gameObject.GetComponent<Renderer> ().enabled = false;
			gameObject.GetComponent<Renderer> ().material.color = Color.gray;
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
		
//		if (cubeColors [cubeIndex] == "red") {
//			gameObject.GetComponent<Renderer> ().material.color = Color.red;
//		} else if (cubeColors [cubeIndex] == "yellow") {
//			gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//		}

//
//		// Code weight number 1 right side
//		if (gameObject.name == "RightCube1") {
//
//
//			if (Valores.pnr1 == 1 || Valores.pnr2 == 1) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//
//			if ((Valores.colorname3 == "red" && Valores.pnr1 == 1) || (Valores.colorname4 == "red" && Valores.pnr2 == 1)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname3 == "yellow" && Valores.pnr1 == 1) || (Valores.colorname4 == "yellow" && Valores.pnr2 == 1)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}
//		} else if (gameObject.name == "RightCube2") {
//			
//			if (Valores.pnr1 == 2 || Valores.pnr2 == 2) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			
//			if ((Valores.colorname3 == "red" && Valores.pnr1 == 2) || (Valores.colorname4 == "red" && Valores.pnr2 == 2)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname3 == "yellow" && Valores.pnr1 == 2) || (Valores.colorname4 == "yellow" && Valores.pnr2 == 2)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}
//			
//		} else if (gameObject.name == "RightCube3") {
//			
//			if (Valores.pnr1 == 3 || Valores.pnr2 == 3) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			
//			if ((Valores.colorname3 == "red" && Valores.pnr1 == 3) || (Valores.colorname4 == "red" && Valores.pnr2 == 3)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname3 == "yellow" && Valores.pnr1 == 3) || (Valores.colorname4 == "yellow" && Valores.pnr2 == 3)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}			
//		} else if (gameObject.name == "RightCube4") {
//			
//			if (Valores.pnr1 == 4 || Valores.pnr2 == 4) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			
//			if ((Valores.colorname3 == "red" && Valores.pnr1 == 4) || (Valores.colorname4 == "red" && Valores.pnr2 == 4)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname3 == "yellow" && Valores.pnr1 == 4) || (Valores.colorname4 == "yellow" && Valores.pnr2 == 4)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			} 
//
//		} else if (gameObject.name == "RightCube5") {
//			
//			if (Valores.pnr1 == 5 || Valores.pnr2 == 5) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			
//			if ((Valores.colorname3 == "red" && Valores.pnr1 == 5) || (Valores.colorname4 == "red" && Valores.pnr2 == 5)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//		
//			} else if ((Valores.colorname3 == "yellow" && Valores.pnr1 == 5) || (Valores.colorname4 == "yellow" && Valores.pnr2 == 5)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}	
//
//		} else if (gameObject.name == "RightCube6") {
//			
//			if (Valores.pnr1 == 6 || Valores.pnr2 == 6) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			
//			if ((Valores.colorname3 == "red" && Valores.pnr1 == 6) || (Valores.colorname4 == "red" && Valores.pnr2 == 6)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//				
//			} else if ((Valores.colorname3 == "yellow" && Valores.pnr1 == 6) || (Valores.colorname4 == "yellow" && Valores.pnr2 == 6)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}	
//		} 
//	
//		// end of right side	
//		// start of left side
//
//		if (gameObject.name == "LeftCube1") {
//			
//			if (Valores.pnl1 == 1 || Valores.pnl2 == 1) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			
//			if ((Valores.colorname1 == "red" && Valores.pnl1 == 1) || (Valores.colorname2 == "red" && Valores.pnl2 == 1)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname1 == "yellow" && Valores.pnl1 == 1) || (Valores.colorname2 == "yellow" && Valores.pnl2 == 1)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}
//		} else if (gameObject.name == "LeftCube2") {
//			
//			if (Valores.pnl1 == 2 || Valores.pnl2 == 2) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			
//			if ((Valores.colorname1 == "red" && Valores.pnl1 == 2) || (Valores.colorname2 == "red" && Valores.pnl2 == 2)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname1 == "yellow" && Valores.pnl1 == 2) || (Valores.colorname2 == "yellow" && Valores.pnl2 == 2)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}
//		} else if (gameObject.name == "LeftCube3") {
//			
//			if (Valores.pnl1 == 3 || Valores.pnl2 == 3) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			if ((Valores.colorname1 == "red" && Valores.pnl1 == 3) || (Valores.colorname2 == "red" && Valores.pnl2 == 3)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname1 == "yellow" && Valores.pnl1 == 3) || (Valores.colorname2 == "yellow" && Valores.pnl2 == 3)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}
//		} else if (gameObject.name == "LeftCube4") {
//			
//			if (Valores.pnl1 == 4 || Valores.pnl2 == 4) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			if ((Valores.colorname1 == "red" && Valores.pnl1 == 4) || (Valores.colorname2 == "red" && Valores.pnl2 == 4)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname1 == "yellow" && Valores.pnl1 == 4) || (Valores.colorname2 == "yellow" && Valores.pnl2 == 4)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}
//		} 
//		else if (gameObject.name == "LeftCube5") {
//			
//			if (Valores.pnl1 == 5 || Valores.pnl2 == 5) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			if ((Valores.colorname1 == "red" && Valores.pnl1 == 5) || (Valores.colorname2 == "red" && Valores.pnl2 == 5)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname1 == "yellow" && Valores.pnl1 == 5) || (Valores.colorname2 == "yellow" && Valores.pnl2 == 5)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}
//		} 
//		else if (gameObject.name == "LeftCube6") {
//			
//			if (Valores.pnl1 == 6 || Valores.pnl2 == 6) {
//				gameObject.GetComponent<Collider> ().enabled = true;
//				gameObject.GetComponent<Renderer> ().enabled = true;
//			} else {
//				gameObject.GetComponent<Collider> ().enabled = false;
//				gameObject.GetComponent<Renderer> ().enabled = false;
//			}
//			if ((Valores.colorname1 == "red" && Valores.pnl1 == 6) || (Valores.colorname2 == "red" && Valores.pnl2 == 6)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//			} else if ((Valores.colorname1 == "yellow" && Valores.pnl1 == 6) || (Valores.colorname2 == "yellow" && Valores.pnl2 == 6)) {
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}
//
//		}
	

