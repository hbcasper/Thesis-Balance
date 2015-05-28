using UnityEngine;
using System.Collections;

public class Restarttogrey : MonoBehaviour {

	//HelloGiana!
		public Receivedweight[] restartgray;
		
		// Use this for initialization
		public void Restartgraycolor() {
			
			Debug.Log ("1");
			
			restartgray = gameObject.GetComponentsInChildren<Receivedweight> ();
			foreach (Receivedweight script in restartgray) {
				
				script.restartreceivedcolor();
			}
		}

}
