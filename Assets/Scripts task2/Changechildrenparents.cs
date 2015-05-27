using UnityEngine;
using System.Collections;

public class Changechildrenparents : MonoBehaviour {

	public TransformWeightsParent Weight1;

	public TransformWeightsParent Weight2;
	public TransformWeightsParent Weight3;
	public TransformWeightsParent Weight4;




	// Use this for initialization
	public void moveweights() {
		Weight1.Changeparent ();
		Weight2.Changeparent ();
		Weight3.Changeparent ();
		Weight4.Changeparent ();
	}
	


}
