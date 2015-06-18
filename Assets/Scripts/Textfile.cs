using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System; 

public class Textfile : MonoBehaviour {
	
	//int time;
	// takes the trial number to print 
	private Gamemanager Tasknumber;
	private GameObject tasknumber; 
	
	
	// takes the number of weights for each trial
	private Instruction Weightnumber;
	private GameObject weightnumber; 
	
	// takes the correct input 
	private ArduinoInputBehavior CorrectButton;
	private GameObject correctButton; 
	
	// takes the user input 
	private Animate Useranswer; 
	private GameObject useranswer; 
	
	// takes the position for each cube 
	private Instruction CubePosition;
	private GameObject cubePosition; 

	private Userfinaldata FinalData;
	private GameObject finalData; 
	
	private StreamWriter writer;  
	string sceneName; 
	string logFileName; 
//	int loggedTask;
	int loggedCorrect; 
//	int loggedUserButton; 
	int loggedCorrectButton; 
	int loggedLevelNumber; 
	int loggedScore; 
	int loggedNumberWeightsRed; 
	int loggedNumberWeightsYellow;
	
	public DateTime startTime;
	public DateTime readyTime;
	public DateTime endTime;

	TimeSpan reactionTime1; 
	TimeSpan reactionTime2;
	TimeSpan reactionTime3; 
	
	
	void Start () {


		
		cubePosition = GameObject.Find ("Instructions"); 
		CubePosition = cubePosition.GetComponent<Instruction> (); 
		
		weightnumber = GameObject.Find ("Instructions"); 
		Weightnumber = weightnumber.GetComponent<Instruction> (); 
		
		tasknumber = GameObject.Find ("Exercisemanager");
		Tasknumber = tasknumber.GetComponent<Gamemanager> ();
		
		useranswer = GameObject.Find ("Scale"); 
		Useranswer = useranswer.GetComponent<Animate> ();
		
		correctButton = GameObject.Find ("Scale");
		CorrectButton = correctButton.GetComponent<ArduinoInputBehavior> (); 

		finalData = GameObject.Find ("Userdata");
		FinalData = finalData.GetComponent<Userfinaldata> ();
		
		sceneName = Application.loadedLevelName; 

//		Debug.Log (FinalData.gender.ToString ());
		StoreStartTime (); 
		createLogFile (); 
		
	}
	
	private void createLogFile(){
		
		//string logFilePath = @"Assets\Resources\" + sceneName + "_balancescale_nr_";
		 string logFilePath = @"FileManager\Resources\" + sceneName + "_balancescale_nr_"; // TabletVersion
		int version = 0;
		logFileName = logFilePath + version + ".txt";
		
		
		while (File.Exists(logFileName)) {
			version ++;
			
			logFileName = logFilePath + version + ".txt";
		}
		
		writer = new StreamWriter (logFileName);
		writer.Write ("Date and time: " + System.DateTime.Now.ToString());
		writer.WriteLine (); 
		writer.Write ("Participant #: " + FinalData.participantNumber.ToString ());
		writer.WriteLine (); 
		writer.Write ("Age: " + FinalData.participantAge.ToString());
		writer.WriteLine (); 	      
		writer.WriteLine ("_____________________________________________________________________________________________________________________________________________________________________"); 
		writer.WriteLine ("Trial#  , Correct , Button Correct , Button Pressed , Level, Score, #RedWeights, #YellowWeights ,TimeSet, TimeChoose, TimeTotal, RedPos1, RedPos2, YellPos1, YellPos2"); 
		writer.WriteLine ("_____________________________________________________________________________________________________________________________________________________________________"); 
		
	}
	
	public void StoreStartTime ()
	{
		startTime = System.DateTime.Now;

	}
	
	public void StoreReadyTime()
	{
		readyTime = System.DateTime.Now; 
	}
	
	public void StoreEndTime()
	{
		endTime = System.DateTime.Now; 
	}
	
	public void write () {
		
		// Useranswer = gameObject.GetComponent<Animate> ();
		loggedLevelNumber = Tasknumber.levelnumber;
		loggedCorrectButton = CorrectButton.balance; 
//		loggedUserButton = Useranswer.whichbutton; 
		loggedCorrect = Useranswer.correct; 
//		loggedTask = Tasknumber.taskCount;
		loggedScore = Useranswer.score; 
		
		reactionTime1 = readyTime.Subtract(startTime); 
		reactionTime2 = endTime.Subtract(readyTime); 
		reactionTime3 = endTime.Subtract (startTime); 
		
		// reactionTime3 = endTime.Subtract(readyTime); 
		
	
		writer.WriteLine (Tasknumber.taskCount.ToString () + "," + loggedCorrect.ToString () + "," + loggedCorrectButton.ToString() + "," + Useranswer.whichbutton.ToString()+ "," + loggedLevelNumber.ToString() + ","+ loggedScore.ToString() + "," + loggedNumberWeightsRed.ToString() + "," + loggedNumberWeightsYellow.ToString() + "," +  reactionTime1.ToString()+ "," +  reactionTime2.ToString() +"," + reactionTime3.ToString()+","+CubePosition.positionRedCube1.ToString() + "," + CubePosition.positionRedCube2.ToString() + ","+ CubePosition.positionRedCube3.ToString() + "," + CubePosition.positionRedCube4.ToString() +","+ CubePosition.positionYellowCube1.ToString() + "," + CubePosition.positionYellowCube2.ToString() + "," + CubePosition.positionYellowCube3.ToString() + "," + CubePosition.positionYellowCube4.ToString()); 
		writer.Flush ();
		
	}
	
	void Update () {
//		actually unneccessary Update 
//		loggedNumberWeightsRed = Weightnumber.numberWeightsRed; 
//		loggedNumberWeightsYellow = Weightnumber.numberWeightsYellow;
//		loggedCorrectButton = CorrectButton.balance; 
//		loggedUserButton = Useranswer.whichbutton; 
//		loggedCorrect = Useranswer.correct; 
//		loggedTask = Tasknumber.taskCount;
		
	}

}
