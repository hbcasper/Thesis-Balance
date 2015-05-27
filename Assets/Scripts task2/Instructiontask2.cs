using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Instructiontask2 : MonoBehaviour {

	public int side;
	string Sidetask2;
	Text Instructiontask;

	private Gamemanager leveldefined;
	public GameObject level;


	// Use this for initialization
	void Start () {
		leveldefined = level.GetComponent<Gamemanager>();
		Instructiontask = GetComponent <Text> ();
		defineside ();
		level1 ();
	}
	
	// Update is called once per frame


	public void defineside (){
		side = Random.Range(0, 7);
		
		if (side == 0) {
			Sidetask2 = "Stay in equilibrium";
			side = 0;
		}
		
		else if (side >0 && side <=3)
		{
			Sidetask2 = "Falls to the right";
			side = 2;
			
		}
		else if (side >3 && side <=7)
		{
			Sidetask2 = "Falls to the left";
			side = 1;
		}
	}



	public void level1 () {
		Instructiontask = GetComponent <Text> ();

		Instructiontask.text = "Put the weights in a way in which the balance:\n " + Sidetask2 + "\nYou can't use the black spaces";
		
	}
	public void level2 () {
		Instructiontask = GetComponent <Text> ();

		if (Sidetask2 == "Stay in equilibrium") {
			Sidetask2 = "Falls to the right";
		}
		
		Instructiontask.text = "Put the weights in a way in which the balance:\n " + Sidetask2 + "\nYou can't use the black spaces";
		
	}
		public void level3and4(){
		Instructiontask = GetComponent <Text> ();
		
		Instructiontask.text = "Put ALL the weights in a way in which the balance:\n " + Sidetask2 + "\nYou can't use the black spaces" +
			".\nPut weights in both sides";
	}

}
