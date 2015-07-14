using UnityEngine;
using System.Collections;

public class changeimage : MonoBehaviour {

	GameObject exercisemanager;
	randomexercise exercisenumber;
	string scene;

	// Use this for initialization

	void Start(){
		exercisemanager = GameObject.Find ("testmanager");
		exercisenumber = exercisemanager.GetComponent<randomexercise> ();

	}
	void Update(){
		scene = Application.loadedLevelName;
	}



	public void image(){

		if (scene == "Pretesthotair") {

			GetComponent<Renderer> ().material.mainTexture = Resources.Load ("Pre" + exercisenumber.exercise) as Texture; 
		}
		else if (scene == "Pretestscale") {
			
			GetComponent<Renderer> ().material.mainTexture = Resources.Load ("Presca" + exercisenumber.exercise) as Texture; 
		}
		else if (scene == "Posttesthotair") {
			
			GetComponent<Renderer> ().material.mainTexture = Resources.Load ("Post" + exercisenumber.exercise) as Texture; 
		}
		else if (scene == "Posttestscale") {
			
			GetComponent<Renderer> ().material.mainTexture = Resources.Load ("Postsca" + exercisenumber.exercise) as Texture; 
		}
	}
}
