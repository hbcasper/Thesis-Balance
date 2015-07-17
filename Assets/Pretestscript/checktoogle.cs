using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class checktoogle : MonoBehaviour {
	public Selectedtoogle[] Toggles;
	public string userData;



	// Use this for initialization

	void Awake(){
	
		Toggles = gameObject.GetComponentsInChildren<Selectedtoogle> ();
	}



	
	// Update is called once per frame
	public void SaveData() {

		//DATA = Gender, Age, EducationDegree, Studyfield, PhysicsSkills, Videogames, Touchdevices, 


		foreach (Selectedtoogle toogle in Toggles) {
		
			if (toogle.selectedOption != null){
				userData = userData + toogle.selectedOption + ",";
			}
		}
		Debug.Log (userData);

	
	}
	public void LastSaveData() {
		
		//DATA = Gender, Age, EducationDegree, Studyfield, PhysicsSkills, Videogames, Touchdevices, 
		
		
		foreach (Selectedtoogle toogle in Toggles) {
			
			if (toogle.selectedOption != null){
				userData = userData + toogle.selectedOption + ",";
			}
		}
		Debug.Log (userData);
		

			GameObject.Find ("userdata").GetComponent<userdata> ().savepostanswers ();
			
}
}
