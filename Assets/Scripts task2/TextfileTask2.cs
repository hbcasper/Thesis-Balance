using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System; 

public class TextfileTask2 : MonoBehaviour {

	//takes tasknumber to print #trial
	private GamemanagerT2 Tasknumber;
	private GameObject tasknumber; 
	
	//takes correct value to print whether its correct or not 
	private Iscorrect CorrectScore;
	private GameObject correctScore; 
	
	//values of the pressed button and the correct button to press + position and weight of the cubes
	private Calculateside Balanceresult;
	private GameObject balanceresult;

	private Instructiontask2 Balancerequired;
	private GameObject balancerequired;

	private Imused PosRed1;
	private Imused PosRed2;
	private Imused PosYellow1;
	private Imused PosYellow2; 
//
	private GameObject posRed1;
	private GameObject posRed2;
	private GameObject posYellow1;
	private GameObject posYellow2;
//	
	private StreamWriter writer;  
	string sceneName; 
	string logFileName; 
	
	DateTime startTime;
	DateTime readyTime;
	DateTime endTime;
	
	TimeSpan reactionTime1; 
	TimeSpan reactionTime2;
	TimeSpan reactionTime3; 

	int posRed1Int;
	int posRed2Int;
	int posYellow1Int;
	int posYellow2Int;
//
//	void Awake(){
//
//		PosRed1 = new Imused ();
//		PosRed2 = new Imused ();
//		PosYellow1 = new Imused ();
//		PosYellow2 = new Imused ();
//	}

	void Start () {
		

		tasknumber = GameObject.Find ("Gamemanager");
		Tasknumber = tasknumber.GetComponent<GamemanagerT2> ();
		
		correctScore = GameObject.Find ("Gamemanager");
		CorrectScore = correctScore.GetComponent<Iscorrect> (); 
		
		balanceresult = GameObject.Find ("Scale");
		Balanceresult = balanceresult.GetComponent<Calculateside> ();
		
		balancerequired = GameObject.Find ("Instructiontask2");
		Balancerequired = balancerequired.GetComponent<Instructiontask2> ();

		if (GameObject.Find("RedWeightLeft 1")) {
			posRed1 = GameObject.Find ("RedWeightLeft 1");
			PosRed1 = posRed1.GetComponent<Imused> (); 
		}

		if (GameObject.Find("RedWeightLeft 2")) {
			posRed2 = GameObject.Find ("RedWeightLeft 2");
			PosRed2 = posRed2.GetComponent<Imused> (); 
		}

		if (GameObject.Find("YellowWeightLeft 1")) {
			posYellow1 = GameObject.Find ("YellowWeightLeft 1");
			PosYellow1 = posYellow1.GetComponent<Imused> (); 
		}

		if (GameObject.Find("YellowWeightLeft 2")) {
			posYellow2 = GameObject.Find ("YellowWeightLeft 2");
			PosYellow2 = posYellow2.GetComponent<Imused> (); 
		}

		sceneName = Application.loadedLevelName; 
		
		createLogFile (); 
		StoreStartTime (); 
		Debug.Log ("LLLLLLLLLLLOOOOOOOOOOOOOOOOOOOOGGGGGGG");
		
	}
	
	private void createLogFile(){
	

		string logFilePath = @"Assets\ParticipantFiles\" + sceneName + "_balancescale_nr_";
		int version = 0;
		logFileName = logFilePath + version + ".txt";
		
		
		while (File.Exists(logFileName)) {
			version ++;
			
			logFileName = logFilePath + version + ".txt";
		}
		
		writer = new StreamWriter (logFileName);
		writer.Write ("Date and time: ");
		writer.WriteLine (); 
		writer.Write ("Participant #: ");
		writer.WriteLine (); 
		writer.Write ("Day: ");
		writer.WriteLine (); 
		writer.Write ("Age: ");
		writer.WriteLine (); 	      
		writer.WriteLine ("_____________________________________________________________________________________________________________________________________________________________________"); 
		writer.WriteLine ("Trial#  , Correct , Button Correct , Button Pressed , Level, Score, #RedWeights, #YellowWeights , Decision Time, RedPos1, RedPos2, YellPos1, YellPos2"); 
		writer.WriteLine ("_____________________________________________________________________________________________________________________________________________________________________"); 
		// writer.Flush ();
	}
	
	public void StoreStartTime ()
	{
		startTime = System.DateTime.Now;
	}
	
	
	public void StoreEndTime()
	{
		endTime = System.DateTime.Now; 
	}

	public void SetCube()
	{	
		if (GameObject.Find ("RedWeightLeft 1")) {
			posRed1Int = PosRed1.myPos;
		} else {
			posRed1Int = 0;
		}
		if (GameObject.Find ("RedWeightLeft 2")) {
			posRed2Int = PosRed2.myPos;
		} else {
			posRed2Int = 0;
		}
		if (GameObject.Find ("YellowWeightLeft 1")) {
			posYellow1Int = PosYellow1.myPos;
		} else {
			posYellow1Int = 0;
		}
		if (GameObject.Find ("YellowWeightLeft 2")) {
			posYellow2Int = PosYellow2.myPos;	
		} else {
			posYellow2Int = 0;
		}



//	
		Debug.Log ("HEEEEEEEEEEEEERRREEE"+posRed1Int +","+posYellow1Int);
//	
	}

	public void SetZeroCube()
	{
		posRed1Int = 0;
		posRed2Int = 0;
		posYellow1Int = 0;
		posYellow2Int = 0;
	}

	public void write () 
	{

		reactionTime3 = endTime.Subtract (startTime); 

		writer.WriteLine (posRed1Int.ToString () +","+ posRed2Int.ToString() +","+posYellow1Int.ToString () +","+ posYellow2Int.ToString()); 
		//writer.WriteLine (Tasknumber.taskCount.ToString ()+ "," + CorrectScore.Correct.ToString()+ "," + Balanceresult.balance.ToString() + "," + Balancerequired.side.ToString()+ "," +Tasknumber.levelnumber.ToString ()+ "," + CorrectScore.Score.ToString() + "," + "#ofRedWeights" + "," + "#ofYellowWeights" + "," + reactionTime3.ToString());
		//writer.WriteLine (CubePosition.positionRedCube1.ToString ());//+ "," + CubePosition.positionRedCube2.ToString() + ","+ CubePosition.positionRedCube3.ToString() + "," + CubePosition.positionRedCube4.ToString() +"|"+ CubePosition.positionYellowCube1.ToString() + "," + CubePosition.positionYellowCube2.ToString() + "," + CubePosition.positionYellowCube3.ToString() + "," + CubePosition.positionYellowCube4.ToString()); 
		writer.Flush ();
		
	}
	
	void Update () {
		
		//		loggedNumberWeightsRed = Weightnumber.numberWeightsRed; 
		//		loggedNumberWeightsYellow = Weightnumber.numberWeightsYellow;
		//		loggedCorrectButton = CorrectButton.balance; 
		//		loggedUserButton = Useranswer.whichbutton; 
		//		loggedCorrect = Useranswer.correct; 
		//		loggedTask = Tasknumber.taskCount;
		
	}
}
