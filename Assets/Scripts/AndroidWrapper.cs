using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;




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
		try
		{
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("goHome");
		} catch (Exception e){}
	}

	public void goLeft(){
		try
		{
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("goLeft");
	} catch (Exception e){}
	}

	public void goRight(){
		try
		{
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("goRight");
} catch (Exception e){}
	}

	public void getConfiguration(){
	try
		{
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		configuration = currentActivity.Call<string> ("getConfiguration");
		} catch (Exception e){}
		//Text configurationText = GameObject.Find("ConfigText").GetComponent<Text>();
	
//		Text configurationText = GetComponent<Text> ();
	//	configurationText.text = configuration;
	}
	

}