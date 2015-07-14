using UnityEngine;
using System.Collections;

public class userdata : MonoBehaviour {

	public string user;
	GameObject toggles;
	checktoogle answerdata;
	public GameObject emailobject;
	Saveemail emaildata;
	public string email;
	GameObject test;
	string CorrectLog;
	string PerformanceLog;
	string ExerciseLog;
	string AnswerLog;
	string TotalCorrect;
	string usertotaldata;




	// Use this for initialization

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}

	// Update is called once per frame
	public void saveanswers () {
		toggles = GameObject.Find ("Questions");
		answerdata = toggles.GetComponent<checktoogle> ();
		emaildata = emailobject.GetComponent<Saveemail> ();

		user = answerdata.userData;
		email = emaildata.email;

		usertotaldata = user + "," + email;

	}

	public void savetestdata() {
		test = GameObject.Find ("testmanager");
		CorrectLog = test.GetComponent<checkifcorrect> ().answerlog;
		ExerciseLog = test.GetComponent<checkifcorrect> ().exerciselog;
		PerformanceLog = test.GetComponent<checkifcorrect> ().performance;
		TotalCorrect = test.GetComponent<checkifcorrect> ().count.ToString();
		SaveUserTotalData ();

	}

	public void SaveUserTotalData(){

		usertotaldata = usertotaldata + "," + ExerciseLog + "," + AnswerLog + "," + PerformanceLog + "," +TotalCorrect;
		Debug.Log ("usertotaldata: " + usertotaldata);
	}
}
