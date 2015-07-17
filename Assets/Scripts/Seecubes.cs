using UnityEngine;
using System.Collections;


public class Seecubes : MonoBehaviour {

	// private Instruction Valores; 
	private Instruction Valores;
	GameObject Objeto;	
	public string colorName; 
	private ToogleOptions GameConfiguration;
	private GameObject GameConfigurationToogles;
	public int cubeColor=0;
	public bool cubeIsActive=false;
	public int myValue = 0;
	public int cubechanged = 0;
	
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
		
		gameObject.GetComponent<Renderer> ().enabled = false;
		//gameObject.transform.localScale = new Vector3(1.4f,1.4f,1.4f);
		
		GameConfigurationToogles = GameObject.Find ("GameConfiguration");
		GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
	}
	
	void Update () 
	{
		if (GameConfiguration.ActiveAdaptiveDificulty == false) {
			
			ActiveCubesRS ();
	
			calculatecubevalue();

		}
		
		
		
		
	}

	public void checkRScolors(string color){
		if (color == "yellow") {
			cubeColor = 1;
		} else if (color == "red") {
			cubeColor = 2;
		} 
	}

	
	public void ActiveCubesRS(){
		
		if (((Valores.pnr1 == cubeIndex || Valores.pnr2 == cubeIndex) && gameObject.tag == "Right")||((Valores.pnl1 == cubeIndex || Valores.pnl2 == cubeIndex) && gameObject.tag == "Left"))
		{
			gameObject.GetComponent<Collider> ().enabled = true;
			gameObject.GetComponent<Renderer> ().enabled = true;
			cubeIsActive = true;
		} else {
			gameObject.GetComponent<Collider> ().enabled = false;	
			gameObject.GetComponent<Renderer> ().enabled = false;
			cubeIsActive = false;
			
		}
		
		if ((Valores.pnr1 == cubeIndex) && gameObject.tag == "Right"){
			Colorchange (Valores.colorname3);
			colorName = Valores.colorname3;
			checkRScolors(Valores.colorname3);
		}
		else if 
		((Valores.pnr2 == cubeIndex)  && gameObject.tag == "Right"){
			Colorchange (Valores.colorname4);
			colorName = Valores.colorname4;
			checkRScolors(Valores.colorname4);

		}
		else if 
		((Valores.pnl1 == cubeIndex)  && gameObject.tag == "Left"){
			Colorchange (Valores.colorname1);
			colorName = Valores.colorname1;
			checkRScolors(Valores.colorname1);
		}
		else if 
		((Valores.pnl2 == cubeIndex) && gameObject.tag == "Left"){
			Colorchange (Valores.colorname2);
			colorName = Valores.colorname2;
			checkRScolors(Valores.colorname2);
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
			else {
				cubeIsActive=false;
			}
		}
		else if (gameObject.tag == "Left") 
		{
			if (Cubesconfiguration.Leftcubes.Contains(gameObject.name[nameLenght - 1].ToString()))
			{
				cubeIsActive=true;
				DefineCubeColor ();
				
			}
			else {
				cubeIsActive=false;
			}
		}
		
		
		
	}
	public void NoActiveCubesAD(){
		gameObject.GetComponent<Renderer> ().material.color = Color.clear;
		gameObject.GetComponent<Collider> ().enabled = false;
		myValue = 0;
		cubeColor = 0;
		cubechanged = 0;
		
	}
	
	public void DefineCubeColor(){
		if (cubeIsActive == true) {
			if (Valores.numberofcolors == 1) {
				cubeColor = 2;
			} else if (Valores.numberofcolors == 2) {
				cubeColor = Random.Range (1, 3);
			} 
			definecubevalue ();
		}
	}
	
	public void ChangeColor(int extracolor, int newcolor){
		if (cubeIsActive == true) {
			if (cubeColor == extracolor) {
				cubeColor = newcolor;
				cubechanged = 1;
			}
			definecubevalue ();
		}
		
	}
	
	void definecubevalue(){
		
		if (cubeColor == 2){
			//gameObject.GetComponent<Renderer> ().material.color = Color.red;
			myValue=cubeIndex*2;
			colorName = "red";
			
		}
		else if (cubeColor == 1){
			//gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
			myValue=cubeIndex*1;
			colorName = "yellow";
		}
		//paintcube ();
		
		
	}
	
	public void paintcube(){
		if (cubeIsActive == true) {
			gameObject.GetComponent<Collider> ().enabled = true;
			gameObject.GetComponent<Renderer> ().enabled = true;
			
			if (cubeColor == 2) {
				gameObject.GetComponent<Renderer> ().material.color = Color.red;
				
			} else if (cubeColor == 1) {
				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
				
				
			}
		} else {
			gameObject.GetComponent<Collider> ().enabled = false;
			gameObject.GetComponent<Renderer> ().enabled = false;
		}
		
		
		
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

