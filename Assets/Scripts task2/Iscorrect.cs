using UnityEngine;
using System.Collections;

public class Iscorrect : MonoBehaviour {

	public GameObject requiredside;	
	public GameObject balanceresult;

	public int Correct;

	public int Score = 0;
	
	private Calculateside balancecreated;
	private Instructiontask2 balancerequired;

	// Use this for initialization
	void Start () {
	
		balancecreated = balanceresult.GetComponent<Calculateside> ();
		balancerequired = requiredside.GetComponent<Instructiontask2> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		print ("Balance required: " + balancerequired.side + " Balance created: " + balancecreated.balance);
		print ("Score: " + Score);
	
		if (balancecreated.balance == balancerequired.side){
			Debug.Log ("correct");
			Correct = 1;
		}
		else {
			Debug.Log ("Incorrect");
			Correct = 0;
			}
	}

	public void Scoredisplay (){
		if (balancecreated.balance == balancerequired.side) {
			Score = Score + 1;
		}
	}
}