using UnityEngine;
using System.Collections;
using System;

public class Seecubes : MonoBehaviour {

	// private Instruction Valores; 
	private Instruction Valores;
	GameObject Objeto;	
	public string colorName; 
	private ToogleOptions GameConfiguration;
	private GameObject GameConfigurationToogles;
	int cubeColor=0;
	bool cubeIsActive=false;

	void Start (){

		GameConfigurationToogles = GameObject.Find ("GameConfiguration");

		Objeto = GameObject.Find ("Instructions");
		gameObject.GetComponent<Collider> ().enabled = false;
		//Valores = Objeto.GetComponent<Instruction>();	
		Valores = Objeto.GetComponent<Instruction> (); 
		//gameObject.GetComponent<Renderer> ().enabled = false;
		gameObject.GetComponent<Renderer> ().material.color = Color.clear;
		gameObject.transform.localScale = new Vector3(1.4f,1.4f,1.4f);


	}
	
    void Update () {

		// if es adaptativo{
			//definepaintedcubes ();
		//}
		//if no es adaptativo{
		int nameLenght = gameObject.name.Length;
		int cubeIndex = int.Parse(gameObject.name[nameLenght - 1].ToString());
		
		if (((Valores.pnr1 == cubeIndex || Valores.pnr2 == cubeIndex) && gameObject.tag == "Right")||((Valores.pnl1 == cubeIndex || Valores.pnl2 == cubeIndex) && gameObject.tag == "Left"))
		{
			gameObject.GetComponent<Collider> ().enabled = true;
		} else {
			gameObject.GetComponent<Collider> ().enabled = false;	
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

//		GrowCube (colorName); // Only in Virtual Reality

	}

	void Colorchange(string color){
		
		if (color == "red") {
			gameObject.GetComponent<Renderer> ().material.color = Color.red;

		} else if (color == "yellow") {
			gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
		
		} 
	}

//  Only in Virtual Reality
//	void GrowCube(string colorName){
//
//
//		try
//		{
//		
//			GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
//
//			if (GameConfiguration.ActiveHiddenStates == true)
//			{
//			 	if (colorName == "yellow") {
//				gameObject.transform.localScale = new Vector3(1.4f,3f,1.4f);
//				} 
//			 }
//		} catch (Exception e){}
//
//	}
//	void VisibleWeights(){
//		try
//			{
//				GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
//
//					if (GameConfiguration.ActiveHiddenStates == true)
//					{
//					 	if (colorName == "yellow") {
//						
//							
//						
//						} 
//					 }
//			} catch (Exception e){}
//		
//		}

//
//	void ActiveCube(){
//
//		int nameLenght = gameObject.name.Length;
//		int cubenumber = int.Parse(gameObject.name[nameLenght - 1].ToString());
//		if (gameObject.tag == right) {
//		if (cubenumber Contains rightactivecubes){
//				cubeIsActive=true
//			}
//			else {
//				cubeIsActive=false;
//			}
//			else if (gameObject.tag == left) {
//				if (cubenumber Contains rightactivecubes){
//				cubeIsActive=true
//			}
//			else {
//				cubeIsActive=false;
//			}
//			}
//
//		
//	}
//
//	void definepaintedcubes(){
//
//		//Check addaptive input
//		if (cubeIsActive = true)
//		{
//		if (diff = 1)
//		{Cubecolor =1;}
//		else if (diff = 2)
//		{Cubecolor =Random 1- 3;}
//		else if (diff = 3){
//			Cubecolor = Random 1-4;}
//		}
//		paintcubes();
//
//	void paintcubes(){
//		
//
//			if (Cubecolor = 1){
//				gameObject.GetComponent<Renderer> ().material.color = Color.red;
//		}
//		else if (Cubecolor = 2){
//				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
//			}
//		else if Cubecolor = 3){
//				gameObject.GetComponent<Renderer> ().material.color = Color.green;
//				}
//
//
//	}
}
		


