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
	public string usertotaldata;
	public GameObject answer1object;
	string answer1;
	string answer2;





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
	public void savepostanswers () {
		toggles = GameObject.Find ("Questions");
		answerdata = toggles.GetComponent<checktoogle> ();
		
		user = answerdata.userData;
		answer1 = GameObject.Find ("Answer1").GetComponent<Saveemail> ().email;
		answer2 = GameObject.Find ("Answer2").GetComponent<Saveemail> ().email;

		usertotaldata = usertotaldata + user + "," + answer1+ "," + answer2;
		SaveUserTotalData ();

		
	}

	public void savetestdata() {
		test = GameObject.Find ("testmanager");

		ExerciseLog = test.GetComponent<checkifcorrect> ().exerciselog;
		PerformanceLog = test.GetComponent<checkifcorrect> ().performance;
		TotalCorrect = test.GetComponent<checkifcorrect> ().count.ToString();
		SaveUserTotalData ();

	}

	public void SaveUserTotalData(){

		usertotaldata = usertotaldata + "," + ExerciseLog + "," + PerformanceLog + "," +TotalCorrect;
		Debug.Log ("usertotaldata: " + usertotaldata);
	}
}
