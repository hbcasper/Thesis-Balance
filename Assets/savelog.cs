using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Text;
using System;  


public class savelog : MonoBehaviour {

	int participant;

	bool ActiveData;
	StreamWriter writer;
	
	
	string logFileName;
	string dataTaskLine;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void SaveDataPrePost () {

		createLogFile (); 
		write ();

	
	}
	private void createLogFile(){
		ActiveData = GameObject.Find("GameConfiguration").GetComponent<ToogleOptions> ().Data;
		
		if (ActiveData == true){
			
			string logFilePath = Application.persistentDataPath + @"participant_PrePost"; //tablet
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
	public void write () {
		if (ActiveData == true){
			


			dataTaskLine = gameObject.GetComponent<userdata>().usertotaldata;
	
			
			try{
				writer.WriteLine (dataTaskLine);
				
				
				writer.Flush ();
			} catch (Exception e){}
		}
		
	}

}
