using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoredisplayT2 : MonoBehaviour {


	private Iscorrect Scorecalculator;
	public GameObject Scorescript;
	Text text;


	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
		Scorecalculator = Scorescript.GetComponent<Iscorrect>();
	}
	
	// Update is called once per frame
	void Update () 

		{
		text.text = "Score:" + Scorecalculator.Score;
			
		}
	
	
}
