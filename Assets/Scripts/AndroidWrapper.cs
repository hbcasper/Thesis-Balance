using UnityEngine;
using UnityEngine.UI;
using System.Collections;




public class AndroidWrapper : MonoBehaviour {

	public string configuration;

	private void Start () {
		//Screen.orientation = ScreenOrientation.Portrait;
		//Debug.Log ("Start");
	}

	private void Update(){
		//if (Input.GetKeyDown(KeyCode.Escape)) 
		//	Application.Quit(); 
	}

	
	public void goHome(){
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("goHome");
	}

	public void goLeft(){
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("goLeft");
	}

	public void goRight(){
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("goRight");
	}

	public void getConfiguration(){
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		configuration = currentActivity.Call<string> ("getConfiguration");
		//Text configurationText = GameObject.Find("ConfigText").GetComponent<Text>();
	
//		Text configurationText = GetComponent<Text> ();
	//	configurationText.text = configuration;
	}


}