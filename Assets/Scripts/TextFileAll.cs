//using UnityEngine;
//using System.Collections;
//using System.IO;
//using UnityEngine.UI;
//using System.Text;
//using System; 
//
//public class TextFileAll : MonoBehaviour {
//
//	
//	//int time;
//	// takes the trial number to print 
//	private Gamemanager Tasknumber;
//	private GameObject tasknumber; 
//	
//	
//	// takes the number of weights for each trial
//	private Instruction Weightnumber;
//	private GameObject weightnumber; 
//	
//	//Settings of trial: Participant#; AR, HS, AD
//	private ToogleOptions Settings; 
//	private GameObject settings; 
//	
//	// takes the correct input 
//	private ArduinoInputBehavior CorrectButton;
//	private GameObject correctButton; 
//	
//	// takes the user input 
//	private Animate Useranswer; 
//	private GameObject useranswer; 
//	
//	// takes the position for each cube 
//	private Instruction CubePosition;
//	private GameObject cubePosition; 
//	
//	//Participant #
//	private Capturetextdata ParticipantNumber;
//	private GameObject participantNumber; 
//
//	//Participant Age
//	private Userfinaldata UserData;
//	private GameObject userData; 
//
//	//takes tasknumber to print #trial
//	private GamemanagerT2 Tasknumber2;
//	private GameObject tasknumber2; 
//	
//	//takes correct value to print whether its correct or not 
//	private Iscorrect CorrectScore;
//	private GameObject correctScore; 
//	
//	//values of the pressed button and the correct button to press + position and weight of the cubes
//	private Calculateside Balanceresult;
//	private GameObject balanceresult;
//	
//	private Instructiontask2 Balancerequired;
//	private GameObject balancerequired;
//	
//	
//	private StreamWriter writer;  
//	string sceneName; 
//	string logFileName; 
//	int loggedTask;
//	int loggedCorrect; 
//	int loggedUserButton; 
//	int loggedCorrectButton; 
//	int loggedLevelNumber; 
//	int loggedScore; 
//	int loggedNumberWeightsRed; 
//	int loggedNumberWeightsYellow;
//
//	private Imused PosRed1;
//	private Imused PosRed2;
//	private Imused PosYellow1;
//	private Imused PosYellow2; 
//	//
//	private GameObject posRed1;
//	private GameObject posRed2;
//	private GameObject posYellow1;
//	private GameObject posYellow2;
//	
//	DateTime startTime;
//	DateTime readyTime;
//	DateTime endTime;
//
//	TimeSpan reactionTime1; 
//	TimeSpan reactionTime2;
//	TimeSpan reactionTime3; 
//
//	int posRed1Int;
//	int posRed2Int;
//	int posYellow1Int;
//	int posYellow2Int;
//	//
//	
//	void Start () {
//
//		DontDestroyOnLoad (transform.gameObject);
//		
//		cubePosition = GameObject.Find ("Instructions"); 
//		CubePosition = cubePosition.GetComponent<Instruction> (); 
//		
//		weightnumber = GameObject.Find ("Instructions"); 
//		Weightnumber = weightnumber.GetComponent<Instruction> (); 
//		
//		tasknumber = GameObject.Find ("Exercisemanager");
//		Tasknumber = tasknumber.GetComponent<Gamemanager> ();
//		
//		useranswer = GameObject.Find ("Scale"); 
//		Useranswer = useranswer.GetComponent<Animate> ();
//		
//		correctButton = GameObject.Find ("Scale");
//		CorrectButton = correctButton.GetComponent<ArduinoInputBehavior> (); 
//		
//		settings = GameObject.Find ("GameConfiguration"); 
//		Settings = useranswer.GetComponent<ToogleOptions> ();
//		
//		participantNumber = GameObject.Find ("ParticipantNumberText"); 
//		ParticipantNumber = useranswer.GetComponent<Capturetextdata> ();
//
//		userData = GameObject.Find ("Userdata"); 
//		UserData = useranswer.GetComponent<Userfinaldata> ();
//
////		tasknumber2 = GameObject.Find ("Gamemanager");
////		Tasknumber2 = tasknumber.GetComponent<GamemanagerT2> ();
////		
////		correctScore = GameObject.Find ("Gamemanager");
////		CorrectScore = correctScore.GetComponent<Iscorrect> (); 
////		
////		balanceresult = GameObject.Find ("Scale");
////		Balanceresult = balanceresult.GetComponent<Calculateside> ();
////		
////		balancerequired = GameObject.Find ("Instructiontask2");
////		Balancerequired = balancerequired.GetComponent<Instructiontask2> ();
////		
////		if (GameObject.Find("RedWeightLeft 1")) {
////			posRed1 = GameObject.Find ("RedWeightLeft 1");
////			PosRed1 = posRed1.GetComponent<Imused> (); 
////		}
////		
////		if (GameObject.Find("RedWeightLeft 2")) {
////			posRed2 = GameObject.Find ("RedWeightLeft 2");
////			PosRed2 = posRed2.GetComponent<Imused> (); 
////		}
////		
////		if (GameObject.Find("YellowWeightLeft 1")) {
////			posYellow1 = GameObject.Find ("YellowWeightLeft 1");
////			PosYellow1 = posYellow1.GetComponent<Imused> (); 
////		}
////		
////		if (GameObject.Find("YellowWeightLeft 2")) {
////			posYellow2 = GameObject.Find ("YellowWeightLeft 2");
////			PosYellow2 = posYellow2.GetComponent<Imused> (); 
////		}
//
//		
//		// sceneName = Application.loadedLevelName; 
//		sceneName = "Settings"; 
//
//		//StoreStartTime (); 
//		createLogFile (); 
//		
//	}
//	
//	public void createLogFile(){
//		
//		string logFilePath = @"Assets\ParticipantFiles\" + "_balancescale_nr_";
//		int version = 0;
//		logFileName = logFilePath + version + ".txt";
//		
//		
//		while (File.Exists(logFileName)) {
//			version ++;
//			
//			logFileName = logFilePath + version + ".txt";
//		}
//		
//		writer = new StreamWriter (logFileName);
//		writer.Write ("Date and time: " + System.DateTime.Now.ToString());
//		writer.WriteLine (); 
//		writer.Write ("Participant #: " + UserData.participantNumber.ToString());
//		writer.WriteLine (); 
////		writer.Write ("Day: ");
////		writer.WriteLine (); 
//		writer.Write ("Condition: " + Settings.condition.ToString());
//		writer.WriteLine (); 
//		writer.Write ("Age: " + UserData.participantAge.ToString());
//		writer.WriteLine (); 	      
//		writer.Write ("Gender: " + UserData.gender.ToString());
//		writer.WriteLine (); 	      
//		writer.WriteLine ("_____________________________________________________________________________________________________________________________________________________________________"); 
//		writer.WriteLine ("Task# , Trial#  , Correct , Button Correct , Button Pressed , Level, Score, #RedWeights, #YellowWeights ,TimeSet, TimeChoose, TimeTotal, RedPos1, RedPos2, YellPos1, YellPos2"); 
//		writer.WriteLine ("_____________________________________________________________________________________________________________________________________________________________________"); 
//
//		Debug.Log ("FILE CREATED LOGFILE");
//	}
//
//	public void SetSceneName(){
//
//		sceneName = Application.loadedLevelName; 
//	}
//
//	public void StoreStartTime ()
//	{
//		startTime = System.DateTime.Now;
//	}
//	
//	public void StoreReadyTime()
//	{
//		readyTime = System.DateTime.Now; 
//	}
//	
//	public void StoreEndTime()
//	{
//		endTime = System.DateTime.Now; 
//	}
//	
//	public void write () {
//		
//		// Useranswer = gameObject.GetComponent<Animate> ();
//		loggedLevelNumber = Tasknumber.levelnumber;
//		loggedCorrectButton = CorrectButton.balance; 
//		loggedUserButton = Useranswer.whichbutton; 
//		loggedCorrect = Useranswer.correct; 
//		loggedTask = Tasknumber.taskCount;
//		loggedScore = Useranswer.score; 
//		
//		reactionTime1 = readyTime.Subtract(startTime); 
//		reactionTime2 = endTime.Subtract(readyTime); 
//		reactionTime3 = endTime.Subtract (startTime); 
//		
//		// reactionTime3 = endTime.Subtract(readyTime); 
//		
//		
//		writer.WriteLine (sceneName.ToString() +","+Tasknumber.taskCount.ToString () + "," + loggedCorrect.ToString () + "," + loggedCorrectButton.ToString() + "," + Useranswer.whichbutton.ToString()+ "," + loggedLevelNumber.ToString() + ","+ loggedScore.ToString() + "," + loggedNumberWeightsRed.ToString() + "," + loggedNumberWeightsYellow.ToString() + "," +  reactionTime1.ToString()+ "," +  reactionTime2.ToString() +"," + reactionTime3.ToString()+","+CubePosition.positionRedCube1.ToString() + "," + CubePosition.positionRedCube2.ToString() + ","+ CubePosition.positionRedCube3.ToString() + "," + CubePosition.positionRedCube4.ToString() +","+ CubePosition.positionYellowCube1.ToString() + "," + CubePosition.positionYellowCube2.ToString() + "," + CubePosition.positionYellowCube3.ToString() + "," + CubePosition.positionYellowCube4.ToString()); 
//		writer.Flush ();
//		
//	}
//
//	public void SetCube()
//	{	
//		if (GameObject.Find ("RedWeightLeft 1")) {
//			posRed1Int = PosRed1.myPos;
//		} else {
//			posRed1Int = 0;
//		}
//		if (GameObject.Find ("RedWeightLeft 2")) {
//			posRed2Int = PosRed2.myPos;
//		} else {
//			posRed2Int = 0;
//		}
//		if (GameObject.Find ("YellowWeightLeft 1")) {
//			posYellow1Int = PosYellow1.myPos;
//		} else {
//			posYellow1Int = 0;
//		}
//		if (GameObject.Find ("YellowWeightLeft 2")) {
//			posYellow2Int = PosYellow2.myPos;	
//		} else {
//			posYellow2Int = 0;
//		}
//		
//		
//		
//		//	
//		Debug.Log ("HEEEEEEEEEEEEERRREEE"+posRed1Int +","+posYellow1Int);
//		//	
//	}
//	
//	public void SetZeroCube()
//	{
//		posRed1Int = 0;
//		posRed2Int = 0;
//		posYellow1Int = 0;
//		posYellow2Int = 0;
//	}
//
//	public void writeTask2(){
//
//		reactionTime3 = endTime.Subtract (startTime); 
//		
//		writer.WriteLine (posRed1Int.ToString () +","+ posRed2Int.ToString() +","+posYellow1Int.ToString () +","+ posYellow2Int.ToString()); 
//		//writer.WriteLine (Tasknumber.taskCount.ToString ()+ "," + CorrectScore.Correct.ToString()+ "," + Balanceresult.balance.ToString() + "," + Balancerequired.side.ToString()+ "," +Tasknumber.levelnumber.ToString ()+ "," + CorrectScore.Score.ToString() + "," + "#ofRedWeights" + "," + "#ofYellowWeights" + "," + reactionTime3.ToString());
//		//writer.WriteLine (CubePosition.positionRedCube1.ToString ());//+ "," + CubePosition.positionRedCube2.ToString() + ","+ CubePosition.positionRedCube3.ToString() + "," + CubePosition.positionRedCube4.ToString() +"|"+ CubePosition.positionYellowCube1.ToString() + "," + CubePosition.positionYellowCube2.ToString() + "," + CubePosition.positionYellowCube3.ToString() + "," + CubePosition.positionYellowCube4.ToString()); 
//		writer.Flush ();
//		
//	}
//	
//	void Update () {
//		
//		loggedNumberWeightsRed = Weightnumber.numberWeightsRed; 
//		loggedNumberWeightsYellow = Weightnumber.numberWeightsYellow;
//		loggedCorrectButton = CorrectButton.balance; 
//		loggedUserButton = Useranswer.whichbutton; 
//		loggedCorrect = Useranswer.correct; 
//		loggedTask = Tasknumber.taskCount;
//		
//	}
//	
//	
//	
//}
