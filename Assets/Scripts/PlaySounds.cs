using UnityEngine;
using System.Collections;

public class PlaySounds : MonoBehaviour {

	public AudioClip correct;
	public AudioClip incorrect;
	AudioSource audio;

	private Animate Result;
	GameObject Scale;


	void Start() {
		Scale = GameObject.Find ("Scale");
		Result = Scale.GetComponent<Animate> ();

		audio = GetComponent<AudioSource>();
		//ResultCorrect ();
	}

	public void PlayFeedback(){
		
		if (Result.correct == 0) { 
			
			ResultInCorrect ();
			
		}
		
		if (Result.correct == 1) {
			
			ResultCorrect ();
		}
	}

	// Use this for initialization
	public void ResultCorrect(){
		audio.PlayOneShot (correct);
	}

	public void ResultInCorrect(){
		audio.PlayOneShot (incorrect);
	}


}
