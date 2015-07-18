using UnityEngine;
using System.Collections;
using System.Text;
using System;
using UnityEngine.UI;

public class Instruction : MonoBehaviour 

{
	public GameObject levelcomesfrom; // level comes from Excercise Manager
	private Gamemanager levelis;

	// Check if is AD or RS
	private ToogleOptions GameConfiguration;
	private GameObject GameConfigurationToogles;
	private GameObject ExcerciseManager;
	private InputOutputADS ADSystem;
	public string AdaptiveLevel;


	//AD variables
	public string rightSideAD;
	public string leftSideAD;
	public int numberofplaces;
	public int numberofcolors;
	public int side;


	// number of the active cube (max. 2)
	public int pnl1;
	public int pnl2;
	public int pnr1;
	public int pnr2;

	// Define the color with random (pcolor) and assign the color of the active cubes depending in the value (colorname) (max. 2)
	
	public float pcolor1;
	public string colorname1; 
	public float pcolor2;
	public string colorname2; 
	public float pcolor3;
	public string colorname3; 
	public float pcolor4;
	public string colorname4; 
	
	public int LeftW1;
	public int LeftW2;
	public int RightW1;
	public int RightW2;

	// variables for the TextLog
	public int numberWeightsRed; 
	public int numberWeightsYellow; 
	
	public int positionRedCube1; 
	public int positionRedCube2; 
	public int positionYellowCube1;
	public int positionYellowCube2;
	
	public int positionRedCube3; 
	public int positionRedCube4; 
	public int positionYellowCube3;
	public int positionYellowCube4;
	
	Text instruction;
	
	void Start () {
		levelis = levelcomesfrom.GetComponent<Gamemanager> (); //Declare level

		ADSystem = levelcomesfrom.GetComponent<InputOutputADS> (); //Declare ADS variables

	
			GameConfigurationToogles = GameObject.Find ("GameConfiguration");
			GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
			
			if (GameConfiguration.ActiveAdaptiveDificulty == false && GameConfiguration.ActiveAdaptiveLevels == false) //If ADS & ADSLevels are not active run reactive system
			{
				level1 (); 
			}

			else if(GameConfiguration.ActiveAdaptiveLevels == true){ // If ADLevels is active run Adaptive levels
				AdaptiveLevels();
			}




	}

	public void SetInstructions (){



		if (GameConfiguration.ActiveAdaptiveDificulty == true) {
			ADexercise ();
		} else if (GameConfiguration.ActiveAdaptiveLevels == true) {
			AdaptiveLevels ();
			
		} else {
			displayinstructions ();
		}
	}



	
	public void displayinstructions (){ // Run the instructions every time that you press "Next Excercise" button. 


		if (levelis.levelnumber == 1) {
			level1 ();	
		} else if (levelis.levelnumber == 2) {
			level2 ();
		} else if (levelis.levelnumber == 3) {
			level3 ();
		} else if (levelis.levelnumber == 4) {
			level4 ();
		} 

	}

	public void level1 (){

		instruction = GetComponent <Text> ();

		numberWeightsRed = 0; 
		numberWeightsYellow = 0; 
		
		pnl1 = UnityEngine.Random.Range (1, 7);
		pnl2 = 0;
		pnr1 = pnl1; 
		pnr2 = 0;
		pcolor1 = UnityEngine.Random.Range (0, 4);
		pcolor2 = 0;
		pcolor3 = UnityEngine.Random.Range (0, 4);
		pcolor4 = 0;
		
		positionRedCube1 = 0; 
		positionRedCube2 = 0;
		positionYellowCube1 = 0; 
		positionYellowCube2 = 0; 

		
		if (pcolor1 < 2) {
			colorname1 = "red";
			LeftW1 = 2;
			numberWeightsRed ++;
			positionRedCube1 = (pnl1*(-1)); 
			
		} else {
			colorname1 = "yellow";
			LeftW1 = 1;
			numberWeightsYellow ++; 
			positionYellowCube1 = (pnl1*(-1)); 
			
		}
		if (pcolor3 < 2) {
			colorname3 = "red";
			RightW1 = 2;
			positionRedCube2 = pnr1; 
			numberWeightsRed ++;
			
		} else {
			colorname3 = "yellow";
			RightW1 = 1;
			
			if (positionYellowCube1 != 0){
				positionYellowCube2 = pnr1; }
			else {
				positionYellowCube1 = pnr1; 
			}
			
			numberWeightsYellow ++; 
		}
		
		if (colorname1 == "red" && colorname3== "red")
		{
			colorname3 = "yellow";
			RightW1 = 1;
			numberWeightsRed --; 
			numberWeightsYellow ++;
			if (positionYellowCube1 != 0){
				positionYellowCube2 = pnr1;}
			else{positionYellowCube1 = pnr1;}
			positionRedCube2 = 0; 
			
		}
		if (colorname1 == "yellow" && colorname3== "yellow")
		{
			colorname3 = "red";
			RightW1 = 2;
			numberWeightsRed ++; 
			numberWeightsYellow --; 
			if (positionRedCube1 != 0){
				positionRedCube2 = pnr1;}
			else{positionRedCube2 = pnr1;}
			positionYellowCube2 = 0; 
			
		}		
		
		{
			instruction.text="";
			//instruction.text = "Place:\n1 " + colorname1 + " piece in the left place number " + pnl1 + ".\n1 " + colorname3 + " piece in the right place number " + pnr1;
			
		}
	}
	
	public void level2 (){
		instruction = GetComponent <Text> ();
		
		numberWeightsRed = 0; 
		numberWeightsYellow = 0; 
		
		positionRedCube1 = 0; 
		positionRedCube2 = 0;
		positionYellowCube1 = 0; 
		positionYellowCube2 = 0;
		
		pnl1 = UnityEngine.Random.Range (1, 7);
		pnl2 = 0;
		pnr1 = UnityEngine.Random.Range (1, 7);
		pnr2 = 0;
		pcolor1 = UnityEngine.Random.Range (0, 4);
		pcolor2 = 0;
		pcolor3 = UnityEngine.Random.Range (0, 4);
		pcolor4 = 0;
		
		while (pnl1 == pnr1) {
			pnr1 = UnityEngine.Random.Range (1, 7);
		}
		
	
		
		
		if (pcolor1 < 2) {
			colorname1 = "red";
			LeftW1 = 2;
			numberWeightsRed ++; 
			positionRedCube1 = (pnl1*(-1));
			
		} else {
			colorname1 = "yellow";
			LeftW1 = 1;
			numberWeightsYellow ++; 
			positionYellowCube1 = (pnl1*(-1));
		}
		
		colorname3 = colorname1;
		RightW1 = LeftW1;
		
		if (LeftW1 == 2) {
			numberWeightsRed ++; 
			positionRedCube2 = pnr1; 
			positionYellowCube1 = 0; 
			
		} else {
			numberWeightsYellow ++; 
			positionYellowCube2 = pnr1; 
			positionRedCube1 = 0; 
		}
		
		{
			//instruction.text = "Place:\n1 " + colorname1 + " piece in the left place number " + pnl1 + ".\n1 " + colorname3 + " piece in the right place number " + pnr1;
			instruction.text="";
		}

	}
	
	
	public void level3 (){
		instruction = GetComponent <Text> ();
		
		numberWeightsRed = 0; 
		numberWeightsYellow = 0; 
		
		positionRedCube1 = 0; 
		positionRedCube2 = 0;
		positionYellowCube1 = 0; 
		positionYellowCube2 = 0;
		
		pnl1 = UnityEngine.Random.Range (1, 7);
		pnl2 = 0;
		pnr1 = UnityEngine.Random.Range (1, 7);
		pnr2 = 0;
		pcolor1 = UnityEngine.Random.Range (0, 4);
		pcolor2 = 0;
		pcolor3 = UnityEngine.Random.Range (0, 4);
		pcolor4 = 0;
		
		while (pnl1 == pnl2) {
			pnl2 = UnityEngine.Random.Range (1, 7); 
			
		}
		
		while (pnr1 == pnr2) {
			pnr2 = UnityEngine.Random.Range (1, 7);
			
			
		}
		
		if (pcolor1 < 2) {
			colorname1 = "red";
			LeftW1 = 2;
			numberWeightsRed ++; 
			positionRedCube1 = (pnl1 * (-1));
			
		} else {
			colorname1 = "yellow";
			LeftW1 = 1;
			numberWeightsYellow ++; 
			positionYellowCube1 = (pnl1 * (-1));
		}
		
		
		if (pcolor3 < 2) {
			colorname3 = "red";
			RightW1 = 2;
			numberWeightsRed ++; 
			positionRedCube2 = pnr1; 
			
		} else {
			colorname3 = "yellow";
			RightW1 = 1;
			numberWeightsYellow ++; 
			positionYellowCube2 = pnr1; 
		}
		
		if (colorname1 == "red" && colorname3 == "red") {
			colorname3 = "yellow";
			RightW1 = 1;
			numberWeightsRed --; 
			numberWeightsYellow ++; 
			
			if (positionYellowCube1 != 0) {
				positionYellowCube2 = pnr1;
			} else {
				positionYellowCube1 = pnr1;
			}
			positionRedCube2 = 0; 
			
			// positionYellowCube2 = pnr1; 
			// positionRedCube1 = 0; 
		}
		
		if (colorname1 == "yellow" && colorname3 == "yellow") {
			colorname3 = "red";
			RightW1 = 2;
			numberWeightsRed ++; 
			numberWeightsYellow --; 
			
			if (positionRedCube1 != 0) {
				positionRedCube2 = pnr1;
			} else {
				positionRedCube2 = pnr1;
			}
			positionYellowCube2 = 0; 
			//positionRedCube2 = pnr1; 
			//positionYellowCube1 = 0; 
			
		}
		
		
		{
			instruction.text="";
			//instruction.text = "Place:\n1 " + colorname1 + " piece in the left place number " + pnl1 + ".\n1 " + colorname3 + " piece in the right place number " + pnr1;
			
		}
	}


	public void level4 (){
		instruction = GetComponent <Text> ();
		
		numberWeightsRed = 0; 
		numberWeightsYellow = 0; 
		
		positionRedCube1 = 0; 
		positionRedCube2 = 0; 
		positionYellowCube1 = 0;
		positionYellowCube2 = 0;
		
		positionRedCube3 = 0; 
		positionRedCube4 = 0; 
		positionYellowCube3 = 0;
		positionYellowCube4 = 0;
		
		pnl1 = UnityEngine.Random.Range (1, 7);
		pnl2 = UnityEngine.Random.Range (1, 7);
		pnr1 = UnityEngine.Random.Range (1, 7);
		pnr2 = UnityEngine.Random.Range (1, 7);
		pcolor1 = UnityEngine.Random.Range (0, 4);
		pcolor2 = UnityEngine.Random.Range (0, 4);
		pcolor3 = UnityEngine.Random.Range (0, 4);
		pcolor4 = UnityEngine.Random.Range (0, 4);
		
		while (pnl1 == pnl2) {
			pnl2 = UnityEngine.Random.Range (1, 7);
		}
		
		while (pnr1 == pnr2) {
			pnr2 = UnityEngine.Random.Range (1, 7);
		}


		// --------------Cube 1
		
		if (pcolor1 < 2) {
			colorname1 = "red";
			colorname2 = "yellow";
			LeftW1 = 2;
			LeftW2 = 1;
			numberWeightsRed ++; 
			numberWeightsYellow ++;
			positionRedCube1 = (pnl1*(-1));

			// Gianna's code for cube of colorname2

			if (positionYellowCube1 != 0){
				positionYellowCube2 = (pnl2*(-1));
			}
			else {
				positionYellowCube1 = (pnl2*(-1));
			}

			
		} else {
			colorname1 = "yellow";
			colorname2 = "red";
			LeftW1 = 1;
			LeftW2 = 2;
			numberWeightsYellow ++;
			numberWeightsRed ++; 
			positionYellowCube1 = (pnl1*(-1));

			// Gianna's code for cube of colorname2

			if (positionRedCube1 != 0){
				positionRedCube2 = (pnl2*(-1));
			}
			else {
				positionRedCube1 = (pnl2*(-1));
			}
		}
		
		if (pcolor3 < 2) {
			colorname3 = "red";
			RightW1 = 2;
			numberWeightsRed ++; 
			if (positionRedCube1 != 0) {
				if (positionRedCube2 != 0) {
					positionRedCube3 = pnr1;
				} else {
					positionRedCube2 = pnr1;
				}
			} else {
				positionRedCube1 = pnr1;
			}

			colorname4 = "yellow";
			RightW2 = 1;
			numberWeightsYellow ++; 
			if (positionYellowCube1 != 0) {
				if (positionYellowCube2 != 0) {
					if (positionYellowCube3 != 0) {
						positionYellowCube4 = pnr2;
					} else {
						positionYellowCube3 = pnr2;
					}
				} else {
					positionYellowCube2 = pnr2;
				}
			} else {
				positionYellowCube1 = pnr2;
			}
			
		} else {
			colorname3 = "yellow";
			RightW1 = 1;
			numberWeightsYellow ++; 
			if (positionRedCube1 != 0) {
				if (positionYellowCube2 != 0) {
					positionYellowCube3 = pnr1;
				} else {
					positionYellowCube2 = pnr1;
				}
			} else {
				positionYellowCube1 = pnr1;
			}

			colorname4 = "red";
			RightW2 = 2;
			numberWeightsRed ++; 
			if (positionRedCube1 != 0) {
				if (positionRedCube2 != 0) {
					if (positionRedCube3 != 0) {
						positionRedCube4 = pnr2;
					} else {
						positionRedCube3 = pnr2;
					}
				} else {
					positionRedCube2 = pnr2;
				}
			} else {
				positionRedCube1 = pnr2;
			}
		}

		{
			instruction.text="";
			//instruction.text = "Place:\n1 " + colorname1 + " piece in the left place number " + pnl1 + ".\n1 " + colorname2 + " piece in the left place number " + pnl2 + ".\n1 " + colorname3 + " piece in the right place number " + pnr1 + ".\n1 " + colorname4 + " piece in the right place number " + pnr2;
			
		}
	}


	public void ADexercise(){


		instruction = GetComponent <Text> ();
		instruction.text = "";

		mappedDifficulty ();



		GameObject Cubes = GameObject.Find ("Invisible Spaces");
		Cubes.GetComponent<ColorcubesAD> ().ActiveCubesAD ();
	
		
	}

		    public void mappedDifficulty(){

		if (ADSystem.Parameternumberofcubes <= .5) {
			numberofplaces = 1;
			//rightSideAD = Generatecubespositions(1);
			//leftSideAD = Generatecubespositions(1);

		} else {
			numberofplaces = 2;
			//rightSideAD = Generatecubespositions(2);
			//leftSideAD = Generatecubespositions(2);

		}
		if (ADSystem.Parameternumberofcolors <= .5) {
			numberofcolors = 1;
		} else {
			numberofcolors = 2;
		}

		if (ADSystem.Parameterside <= .3) {
			side = 1;
		} else {
			side = 2;
		}
	}



		


		


		  
	public void AdaptiveLevels(){
//
//		
//		if (levelis.performancelevel >= 60) {
//			if (levelis.levelnumber == 4){
//				levelis.levelnumber = levelis.levelnumber;}
//			else{
//				levelis.levelnumber = levelis.levelnumber + 1;
//			}
//		}
//		if (levelis.performancelevel <= 40) {
//			if (levelis.levelnumber == 1){
//				levelis.levelnumber = levelis.levelnumber;}
//			else {
//				levelis.levelnumber = levelis.levelnumber - 1;}
//		}
//		else {
//			levelis.levelnumber = levelis.levelnumber;
//		}
//		displayinstructions ();
	}

}
	
	
