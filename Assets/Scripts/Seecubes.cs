using UnityEngine;
using System.Collections;


public class Seecubes : MonoBehaviour {

	// private Instruction Valores; 
	private Instruction Valores;
	GameObject Objeto;	
	public string colorName; 
	private ToogleOptions GameConfiguration;
	private GameObject GameConfigurationToogles;
	int cubeColor=0;
	public bool cubeIsActive=false;
	public int myValue = 0;

	int nameLenght; 
	public int cubeIndex;


	GameObject Cubesparent;
	ColorcubesAD Cubesconfiguration;

	private GameObject ExcerciseManager;
	private InputOutputADS ADSystem;

	void Start (){
		nameLenght = gameObject.name.Length;
		cubeIndex =  int.Parse(gameObject.name[nameLenght - 1].ToString());

		Cubesparent = GameObject.Find ("Invisible Spaces");
		Cubesconfiguration = Cubesparent.GetComponent<ColorcubesAD> ();

		Objeto = GameObject.Find ("Instructions");
		ExcerciseManager = GameObject.Find ("Exercisemanager");
		ADSystem = ExcerciseManager.GetComponent<InputOutputADS> ();
		gameObject.GetComponent<Collider> ().enabled = false;

		Valores = Objeto.GetComponent<Instruction> (); 

		gameObject.GetComponent<Renderer> ().material.color = Color.clear;
		gameObject.transform.localScale = new Vector3(1.4f,1.4f,1.4f);

		GameConfigurationToogles = GameObject.Find ("GameConfiguration");
		GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
	}
	
    void Update () 
	{
		if (GameConfiguration.ActiveAdaptiveDificulty == false) {
			
				ActiveCubesRS ();

			if (gameObject.GetComponent<Renderer> ().enabled == true) {
				cubeIsActive = true;
			} else {
				cubeIsActive = false;
			}
			
			
			calculatecubevalue();
			}




	}

	public void ActiveCubesRS(){

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

	public void ActiveCubesAD(){
	
	if (gameObject.tag == "Right")
		{
			if (Cubesconfiguration.Rightcubes.Contains(gameObject.name[nameLenght - 1].ToString()))
			    {
				cubeIsActive=true;
				DefineCubeColor ();
								}
		}
	else if (gameObject.tag == "Left") 
			{
			if (Cubesconfiguration.Leftcubes.Contains(gameObject.name[nameLenght - 1].ToString()))
				{
				cubeIsActive=true;
				DefineCubeColor ();
						
				}
			}
		else {
			cubeIsActive=false;
		}


	}
	public void NoActiveCubesAD(){
		gameObject.GetComponent<Renderer> ().material.color = Color.clear;
		gameObject.GetComponent<Collider> ().enabled = false;
		myValue = 0;
			
	}

	public void DefineCubeColor(){

			if (Valores.numberofcolors == 1) {
				cubeColor = 1;
			} else if (Valores.numberofcolors == 2) {
				cubeColor = Random.Range (1, 3);
			} 
			definecubevalue();
		}


	void definecubevalue(){

		if (cubeColor == 1){
				gameObject.GetComponent<Renderer> ().material.color = Color.red;
				myValue=cubeIndex*2;

		}
		else if (cubeColor == 2){
				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
			myValue=cubeIndex*1;
			}
		paintcube ();


	}

	public void paintcube(){
		if (cubeIsActive == true) {
			gameObject.GetComponent<Collider> ().enabled = true;
		
		if (cubeColor == 1){
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
		
		}
		else if (cubeColor == 2){
			gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
	
		
			}}



	}
void calculatecubevalue() {
		
		if(cubeIsActive == true){
			if (gameObject.GetComponent<Renderer> ().material.color == Color.red)
			{
				myValue=cubeIndex*2;
			}
			if (gameObject.GetComponent<Renderer> ().material.color == Color.yellow)
			{
				myValue=cubeIndex*1;
			}
		}
		else {
			myValue = 0;
		}
		

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

		


