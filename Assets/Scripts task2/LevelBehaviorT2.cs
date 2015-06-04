using UnityEngine;
using System.Collections;

public class LevelBehaviorT2 : MonoBehaviour {

	public Instructiontask2 runlevelinstruction;
	public SpaceblockinglevelsT2 runlevelblocks;

	private Gamemanager levelis;

	private GameObject ExtraRedweight;
	private GameObject ExtraYellowweight;
	private GameObject Redweight;

	
	private GameObject Allweights;

	public int levelnumber;


	void Start(){
		levelnumber = 1;
		ExtraRedweight = GameObject.Find ("RedWeightLeft 2");
		ExtraYellowweight = GameObject.Find ("YellowWeightLeft 2");
		Redweight = GameObject.Find ("RedWeightLeft 1");
		Allweights = GameObject.Find ("Ready");
		level1 ();
		levelis = gameObject.GetComponent<Gamemanager> ();
	}




		public void level1 (){
		levelnumber = 1;
		ExtraRedweight.SetActive (false);
		ExtraYellowweight.SetActive (false);
		Redweight.SetActive (true);
		Allweights.GetComponent<Allweightsdeactivation> ().enabled = false;
		runlevelinstruction.defineside ();
		runlevelinstruction.level1 ();
		runlevelblocks.level1 ();

	}


		public void level2 (){
		levelnumber = 2;
		ExtraRedweight.SetActive (false);
		ExtraYellowweight.SetActive (true);
		Redweight.SetActive (false);
		Allweights.GetComponent<Allweightsdeactivation> ().enabled = false;
		runlevelinstruction.defineside ();
		runlevelinstruction.level2 ();
		runlevelblocks.level2 ();

	}
		public void level3 (){
		levelnumber = 3;
		Redweight.SetActive (true);
		ExtraRedweight.SetActive (false);
		ExtraYellowweight.SetActive (false);
		Redweight.GetComponent<Renderer> ().material.color = Color.red;
		Allweights.GetComponent<Allweightsdeactivation> ().enabled = true;
		runlevelinstruction.defineside ();
		runlevelinstruction.level3and4 ();
		runlevelblocks.level3 ();

	}
		public void level4 (){
		levelnumber = 4;
		Allweights.GetComponent<Allweightsdeactivation> ().enabled = true;
		ExtraRedweight.SetActive (true);
		ExtraYellowweight.SetActive (true);
		runlevelinstruction.defineside ();
		runlevelinstruction.level3and4 ();
		runlevelblocks.level4 ();

	}

}
