using UnityEngine;
using System.Collections;

public class Changechildrenparents : MonoBehaviour {

	public TransformParent Weight1;

	public TransformParent Weight2;
	public TransformParent Weight3;
	public TransformParent Weight4;




	// Use this for initialization
	public void moveweights() {
		Weight1.Changeparent ();
		Weight2.Changeparent ();
		Weight3.Changeparent ();
		Weight4.Changeparent ();
	}
	


}
