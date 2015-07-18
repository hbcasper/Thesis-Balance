using UnityEngine;
using System.Collections;

public class RegisterActiveCubes : MonoBehaviour {
	
	Seecubes[] Cubes;
	public string activecubes;
	string left1 = "0";
	string left2 = "0";
	string right1 = "0";
	string right2 = "0";
	
	
	
	// Use this for initialization
	void Start () {
		Cubes = gameObject.GetComponentsInChildren<Seecubes>();
		
	}



	
	// Update is called once per frame
	public void Checkcubes () {

		left1 = "0";
		left2 = "0";
		right1 = "0";
		right2 = "0";
		
		foreach (Seecubes script in Cubes) {
			
			if (script.cubeIsActive == true) 
			{
				if(script.gameObject.tag == "Left"){
					if (left1 == "0")
					{

						left1= script.cubeIndex.ToString()+"("+ checkcolor(script.cubeColor)+")";
					}
					else if (left2 == "0")
					{
						left2= script.cubeIndex.ToString()+"("+ checkcolor(script.cubeColor)+")";
					}
				}
				if(script.gameObject.tag == "Right"){
					
					if (right1 == "0")
					{
						right1= script.cubeIndex.ToString()+"("+ checkcolor(script.cubeColor)+")";
					}
					else if (right2 == "0")
					{
						right2= script.cubeIndex.ToString()+"("+ checkcolor(script.cubeColor)+")";
					}
					
				}
				
			}
			
		}
		
		activecubes = (left1+","+left2+","+right1+","+right2);
		Debug.Log (activecubes);

	}

		public string checkcolor(int color){
		string c = "";
			if (color == 2) {
			c = "red";
		} else if (color == 1) {
			c = "yellow";
		} else {
			c = "0";
		}

		return c;
		}
	public void erasecubes(){
		left1 = "0";
		left2 = "0";
		right1 = "0";
		right2 = "0";
	}
}