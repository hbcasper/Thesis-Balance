using UnityEngine;
using System.Collections;

public class userdata : MonoBehaviour {

	public string user;
	GameObject toggles;
	checktoogle answerdata;

	GameObject test;
	string CorrectLog;
	string PerformanceLog;
	string ExerciseLog;
	string AnswerLog;
	string TotalCorrect;
	public string usertotaldata;
	//public GameObject answer1object;

	string scene;






	// Use this for initialization

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}

	void Update(){
		scene = Application.loadedLevelName;
	}


	// Update is called once per frame
	public void saveanswers () {
		toggles = GameObject.Find ("Questions");
		answerdata = toggles.GetComponent<checktoogle> ();


		user = answerdata.userData;
	

		usertotaldata = user + ",";

	}
	public void savepostanswers () {
		toggles = GameObject.Find ("Questions");
		answerdata = toggles.GetComponent<checktoogle> ();
		
		user = answerdata.userData;


		usertotaldata = usertotaldata + user;

		if (scene == "PostQuestionnaire") {
			gameObject.GetComponent<savelog> ().SaveDataPrePost ();
		}
		
	}

	public void savetestdata() {
		test = GameObject.Find ("testmanager");

		ExerciseLog = test.GetComponent<checkifcorrect> ().exerciselog;
		PerformanceLog = test.GetComponent<checkifcorrect> ().performance;
		TotalCorrect = test.GetComponent<checkifcorrect> ().count.ToString();
		AnswerLog = test.GetComponent<checkifcorrect> ().answerlog;
		SaveUserTotalData ();

	}

	public void SaveUserTotalData(){

		usertotaldata = usertotaldata + "," + ExerciseLog + "," + AnswerLog + "," + PerformanceLog + "," +TotalCorrect;
		Debug.Log ("usertotaldata: " + usertotaldata);


	}
}
