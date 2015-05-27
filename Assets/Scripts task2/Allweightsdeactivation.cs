using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Allweightsdeactivation : MonoBehaviour {

	public Transform button;

	public GameObject RedW1;
	public GameObject RedW2;
	public GameObject YellW1;
	public GameObject YellW2;
	public GameObject level;

	private Imused Redused1;
	private Imused Redused2;
	private Imused Yellowused3;
	private Imused Yellowused4;
	private LevelBehaviorT2 Levelis;

	// Use this for initialization
	void Start () {

		Redused1 = RedW1.GetComponent<Imused> ();
		Redused2 = RedW2.GetComponent<Imused> ();
		Yellowused3 = YellW1.GetComponent<Imused> ();
		Yellowused4 = YellW2.GetComponent<Imused> ();
		Levelis = level.GetComponent<LevelBehaviorT2> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Levelis.levelnumber == 3) 
		{
			if (Redused1.Inside == 1 && Yellowused3.Inside == 1) 
			{	
				button.GetComponent<Button> ().interactable = true; 	
			} else
			{
				button.GetComponent<Button> ().interactable = false; 
			}
		} else if (Levelis.levelnumber == 4) 
		{
			if (Redused1.Inside == 1 && Yellowused3.Inside == 1 && Redused2.Inside == 1 && Yellowused4.Inside == 1) 
			{	
				if (Redused1.side == Redused2.side || Yellowused3.side == Yellowused4.side){
					button.GetComponent<Button> ().interactable = false; 
				}
				else {
				button.GetComponent<Button> ().interactable = true; 
				}
			} 
			else
			{
				button.GetComponent<Button> ().interactable = false; 
			}			
		}
	}
}
