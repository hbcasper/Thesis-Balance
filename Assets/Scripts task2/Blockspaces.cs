using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Blockspaces : MonoBehaviour {

	private GameObject Readybutton;
	private ReceivedweightT2 somethinginside;
	public int notallow = 0;
	private SpaceblockinglevelsT2 notblock;
	GameObject notblockorder;

	// Use this for initialization
	void Start () {
		notblockorder = GameObject.Find ("Invisible Spaces");
		notblock = notblockorder.GetComponent<SpaceblockinglevelsT2>();

		gameObject.GetComponent<Renderer>().material.color = Color.black;
		Readybutton = GameObject.Find ("Ready");
		somethinginside = gameObject.GetComponent<ReceivedweightT2> ();
		//objectname = gameObject.name;

	}
	void Update () 
	{
		if (notblock.desleftcube1 == gameObject.name || notblock.desleftcube2 == gameObject.name || notblock.desleftcube3 == gameObject.name
			|| notblock.desrightcube1 == gameObject.name || notblock.desrightcube2 == gameObject.name || notblock.desrightcube3 == gameObject.name) {
			gameObject.GetComponent<Renderer> ().material.color = Color.white;
		} else {
			gameObject.GetComponent<Renderer> ().material.color = Color.black;
		}
				
		// Check if the black is empty
		if (gameObject.GetComponent<Renderer> ().material.color == Color.black) 
		{

			if (somethinginside.Cubereceives == 1)
			{
				notallow=1;
			}
			else if (somethinginside.Cubereceives == 0)
			{
				notallow=0;
			}
		}

		}

	
	}

