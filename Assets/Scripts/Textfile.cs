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
	private RegisterActiveCubes CubesOrder;
	private ColorcubesAD Sidetotal;
	
	string dataTaskLine;
	
	int participant;
	
	StreamWriter writer;
	
	
	string logFileName; 
	
	
	//----------- time
	
	DateTime startTask;
	
	
	public DateTime readyTime;
	public DateTime endTime;
	
	TimeSpan reactionTime1; 
	public TimeSpan reactionTime2;
	public TimeSpan reactionTime3; 
	
	InputOutputADS AdaptiveSystem;
	
	
	int TimeCounter(DateTime starttime, DateTime endtime){
		
		int totalseconds;
		TimeSpan TimeResult = endTime.Subtract(starttime); 
		totalseconds = TimeResult.Seconds;
		
		return totalseconds;
		
	}
	
	void Start () {
		
		AdaptiveSystem = gameObject.GetComponent<InputOutputADS> ();
		
		// ------------ Calling variables---------
		Instructions = GameObject.Find ("Instructions"); 
		WeightsConfiguration = Instructions.GetComponent<Instruction> (); 
		
		GameManager = gameObject.GetComponent<Gamemanager> ();
		
		Cubes = GameObject.Find ("Invisible Spaces");
		CubesOrder = Cubes.GetComponent<RegisterActiveCubes> ();
		Sidetotal = Cubes.GetComponent<ColorcubesAD> ();
		
		Scale = GameObject.Find ("Scale"); 
		Useranswer = Scale.GetComponent<Animate> ();
		ScaleCalculator = Scale.GetComponent<ArduinoInputBehavior> (); 
		
		TaskData = GameObject.Find ("GameConfiguration");
		TaskCondition = TaskData.GetComponent<ToogleOptions> ();
		
		// ---------------------
		
		startTask = System.DateTime.Now; 
		
		createLogFile (); 
	}
	
	
	private void createLogFile(){
		
		if (TaskCondition.Data == true){
			
			string logFilePath = Application.persistentDataPath + @"participant_"; //tablet
			//string logFilePath = @"Assets\ParticipantFiles\" + "_balancescale_nr_"; // computer
			int version = 1;
			logFileName = logFilePath + version + ".txt";
			participant = 1;
			
			while (File.Exists(logFileName)) {
				version ++;	
				participant ++;
				logFileName = logFilePath + version + ".txt";
			}
			
			
			writer = new StreamWriter (logFileName);
		}
	} 
	public void StoreStartTime()
	{
		if (TaskCondition.Data == true) {
			startTask = System.DateTime.Now; 
		}
	}
	
	public void StoreReadyTime()
	{
		if (TaskCondition.Data == true) {
			readyTime = System.DateTime.Now; 
		}
	}
	
	public void StoreEndTime()
	{
		if (TaskCondition.Data == true) {
			endTime = System.DateTime.Now; 
		}
	}
	
	public void write () {
		if (TaskCondition.Data == true) {
			

			reactionTime2 = endTime.Subtract (startTask); 

			Debug.Log(reactionTime2.Seconds);
			Debug.Log(reactionTime2.Milliseconds);
			
			// Date, Time, Participant Number, Condition, Trial# , Level, CorrectFallSide , ChoosedFallSide , IsCorrect? , Score, Time to Set, TimetoChoose, Total Time, LeftRedPos, LeftYellPos, RightRedPos, RightYellPos,TotalWeightLeft, TotalWeightRight,DifferenceOfWeights, side parameter, colors parameter, cubes parameter, colors, cubes, equal side
			
			dataTaskLine = (startTask.Day.ToString () + "/"
			                + startTask.Month.ToString () + "/"
			                + startTask.Year.ToString () + ","
			                + startTask.Hour.ToString () + "."
			                + startTask.Minute.ToString () + ","
			                + participant.ToString() + ","
			                + TaskCondition.condition.ToString () + "," 
			                + GameManager.taskCount.ToString () + ","
			                + GameManager.levelnumber.ToString () + ","
			                + ScaleCalculator.balance.ToString () + "," 
			                + Useranswer.whichbutton.ToString () + ","
			                + Useranswer.correct.ToString () + ","
			                + GameManager.score.ToString () + "," 
			                // -----times ----
			                + reactionTime2.ToString () + "," 
			                + "only1time" + "," 
			                + "only1time" + "," 
			                /// ------times
			                + CubesOrder.activecubes + ","
			                + Sidetotal.totalLeft.ToString () + ","   
			                + Sidetotal.totalRight.ToString () + ","
			                + Sidetotal.difference.ToString () + ","
			                + AdaptiveSystem.Parameterside.ToString()+ ","
			                +AdaptiveSystem.Parameternumberofcolors.ToString() + ","
			                +AdaptiveSystem.Parameternumberofcubes.ToString()+ ","
			                +WeightsConfiguration.numberofcolors.ToString() + ","
			                +WeightsConfiguration.numberofplaces.ToString() + ","
			                +WeightsConfiguration.side.ToString()
			                
			                );
			Debug.Log (dataTaskLine);
			
			try{
				writer.WriteLine (dataTaskLine);
				
				
				writer.Flush ();
			} catch (Exception e){}
		}
		
	}
	
	
	
}