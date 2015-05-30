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
	
	private StreamWriter writer;  
	string sceneName; 
	string logFileName; 
	
	DateTime startTime;
	DateTime readyTime;
	DateTime endTime;
	
	TimeSpan reactionTime1; 
	TimeSpan reactionTime2;
	TimeSpan reactionTime3; 

	int posRed1;
	int posRed2;
	int posYellow1;
	int posYellow2;
	
	void Start () {
		

		tasknumber = GameObject.Find ("Gamemanager");
		Tasknumber = tasknumber.GetComponent<GamemanagerT2> ();
		
		correctScore = GameObject.Find ("Gamemanager");
		CorrectScore = correctScore.GetComponent<Iscorrect> (); 
		
		balanceresult = GameObject.Find ("Scale");
		Balanceresult = balanceresult.GetComponent<Calculateside> ();
		
		balancerequired = GameObject.Find ("Instructiontask2");
		Balancerequired = balancerequired.GetComponent<Instructiontask2> ();

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

//	public void CubePos()
//	{
//		if (
//	
//	}

	public void write () 
	{
//		posRed1 = GameObject.Find("RedWeightLeft 1").GetComponent<Imused>().myPos; 
//		posRed2 = GameObject.Find("RedWeightLeft 2").GetComponent<Imused>().myPos; 
//		posYellow1 = GameObject.Find("YellowWeightLeft 1").GetComponent<Imused>().myPos; 
//		posYellow2 = GameObject.Find("YellowWeightLeft 2").GetComponent<Imused>().myPos;

		reactionTime3 = endTime.Subtract (startTime); 

		//writer.WriteLine (posRed1.ToString ()); 
		writer.WriteLine (" " + Tasknumber.taskCount.ToString ()+ ", " + CorrectScore.Correct.ToString()+ ", " + Balanceresult.balance.ToString() + ", " + Balancerequired.side.ToString()+ ", " +Tasknumber.levelnumber.ToString ()+ ", " + CorrectScore.Score.ToString() + ", " + "#ofRedWeights" + ", " + "#ofYellowWeights" + ", " + reactionTime3.ToString());// + "         ,   " + loggedLevelNumber.ToString() + " ,           "+ loggedScore.ToString() + " ,       " + loggedNumberWeightsRed.ToString() + " ,          " + loggedNumberWeightsYellow.ToString() + "   , " +  reactionTime1.ToString()+ " , " +  reactionTime2.ToString() +" , " + reactionTime3.ToString());
		//writer.WriteLine(reactionTime3.ToString());
		//writer.WriteLine (CubePosition.positionRedCube1.ToString() + "," + CubePosition.positionRedCube2.ToString() + ","+ CubePosition.positionRedCube3.ToString() + "," + CubePosition.positionRedCube4.ToString() +"|"+ CubePosition.positionYellowCube1.ToString() + "," + CubePosition.positionYellowCube2.ToString() + "," + CubePosition.positionYellowCube3.ToString() + "," + CubePosition.positionYellowCube4.ToString()); 
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
