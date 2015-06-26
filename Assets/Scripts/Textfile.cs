using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System; 

public class Textfile : MonoBehaviour {

		private Gamemanager GameManager;
		private ToogleOptions TaskCondition;

	private GameObject Scale; 
		private ArduinoInputBehavior ScaleCalculator;
		private Animate Useranswer;

	private GameObject Instructions; 
		private Instruction WeightsConfiguration;

	private GameObject TaskData;

	private GameObject Cubes;
	private Registeractivecubes CubesOrder;
	private ColorcubesAD Sidetotal;


	string dataTaskLine;

	// Config Scene necessary Particpipant# & Age
	//    private Userfinaldata FinalData;
	//    private GameObject finalData; 
	
	StreamWriter writer;  
	string sceneName; 
	string logFileName; 
	//    int loggedTask;
	int loggedCorrect; 
	//    int loggedUserButton; 
	int loggedCorrectButton; 
	int loggedLevelNumber; 
	int loggedScore; 
	int loggedNumberWeightsRed; 
	int loggedNumberWeightsYellow;
	
	DateTime startTask;

	public DateTime startTime;
	public DateTime readyTime;
	public DateTime endTime;
	
	TimeSpan reactionTime1; 
	TimeSpan reactionTime2;
	TimeSpan reactionTime3; 
	
	
	void Start () {
		
		Instructions = GameObject.Find ("Instructions"); 
		WeightsConfiguration = Instructions.GetComponent<Instruction> (); 
		

		GameManager = gameObject.GetComponent<Gamemanager> ();

		Cubes = GameObject.Find ("Invisible Spaces");
		CubesOrder = Cubes.GetComponent<Registeractivecubes> ();
		Sidetotal = Cubes.GetComponent<ColorcubesAD> ();

		
		Scale = GameObject.Find ("Scale"); 
		Useranswer = Scale.GetComponent<Animate> ();
		ScaleCalculator = Scale.GetComponent<ArduinoInputBehavior> (); 
		
		TaskData = GameObject.Find ("GameConfiguration");
		TaskCondition = TaskData.GetComponent<ToogleOptions> ();

	 
		sceneName = Application.loadedLevelName; 
		
		//        Debug.Log (FinalData.gender.ToString ());
		//StoreStartTime (); 
		createLogFile (); 
		
	}
	
	private void createLogFile(){
		
		//string logFilePath = Application.persistentDataPath + @"Assets\Resources\" + sceneName + "_balancescale_nr_"; //tablet
		string logFilePath = @"Assets\ParticipantFiles\" + "_balancescale_nr_"; // computer
		int version = 0;
		logFileName = logFilePath + version + ".txt";

		while (File.Exists(logFileName)) {
			version ++;	
			logFileName = logFilePath + version + ".txt";
		}
		
		writer = new StreamWriter (logFileName);
		startTask = System.DateTime.Now;
		writer.WriteLine (); 
		writer.WriteLine ("Date and Time, Participant Number, Condition, Trial# , Level, CorrectFallSide , ChoosedFallSide , IsCorrect? , Score, TimetoChoose, LeftRedPos, LeftYellPos, RightRedPos, RightYellPos,TotalWeightLeft, TotalWeightRight,DifferenceOfWeights"); 

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
		
		reactionTime1 = readyTime.Subtract(startTime); 
		reactionTime2 = endTime.Subtract(readyTime); 
		reactionTime3 = endTime.Subtract (startTime); 
		
		// reactionTime3 = endTime.Subtract(readyTime); 
		
		
		dataTaskLine = (startTask.Day.ToString () + "/"
			+ startTask.Month.ToString () + "/"
			+ startTask.Year.ToString () + ","
			+ TaskCondition.participantNumber + ","
			+ TaskCondition.condition.ToString () + "," 
			+ GameManager.taskCount.ToString () + ","
			+ GameManager.levelnumber.ToString () + ","
			+ ScaleCalculator.balance.ToString () + "," 
			+ Useranswer.whichbutton.ToString () + ","
			+ Useranswer.correct.ToString () + ","
			+ GameManager.score.ToString () + "," 
		//+ reactionTime1.ToString()+ "," 
			+ reactionTime2.ToString () + "," 
		// + reactionTime3.ToString()+"," 
			+ CubesOrder.activecubes + ","
		     + Sidetotal.totalLeft.ToString() + ","   
		     + Sidetotal.totalRight.ToString() + ","
		     + Sidetotal.difference.ToString()); 
		Debug.Log (dataTaskLine);
		writer.WriteLine (dataTaskLine);

		writer.Flush ();
		
	}
	

	
}