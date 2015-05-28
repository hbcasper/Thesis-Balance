using UnityEngine;
using System.Collections;

public class GrowingLine6Task2 : MonoBehaviour {

	private LineRenderer LineLeft1; 
	
	private float counter1;
	
	private float distance1; 
	
	
	public Color white = Color.white;
	
	private GamemanagerT2 Levelcount;
	private GameObject levelcount; 
	
	public float LineDrawSpeed = 6f; 
	
	public Transform Origin; 
	public Transform destination1;
	public Transform destination2;
	public Transform destination3;
	public Transform destination4;
	public Transform destination5;
	public Transform destination6;
	
	// Get cube position & color
	private SpaceblockinglevelsT2 CubePosition;
	private GameObject cubePosition;  
	
	Vector3 VecDestination1; 
	
	// Use this for initialization
	void Start () {
		
		cubePosition = GameObject.Find ("Invisible Spaces"); 
		CubePosition = cubePosition.GetComponent<SpaceblockinglevelsT2> (); 
		
		levelcount = GameObject.Find ("Gamemanager");
		Levelcount = levelcount.GetComponent<GamemanagerT2> ();
		
	}
	
	public void DecideSetActive()
	{
		if (Levelcount.levelnumber == 4) {
			gameObject.SetActive(true);
			DrawLine();
			Debug.Log ( "Line is Activvvvvvvvvvvvveeeee Script 4");
		}
	}
	
	public void DrawLine(){
		
		LineLeft1 = GetComponent<LineRenderer>(); 
		LineLeft1.SetColors (white, white);
		
		if (CubePosition.rcubenumber3 == 1) {
			distance1 = Vector3.Distance (Origin.position, destination1.position);
			VecDestination1 = destination1.position;
			
		} else if (CubePosition.rcubenumber3 == 2) {
			distance1 = Vector3.Distance (Origin.position, destination2.position);
			VecDestination1 = destination2.position;
			
		} else if (CubePosition.rcubenumber3 == 3) {
			distance1 = Vector3.Distance (Origin.position, destination3.position);
			VecDestination1 = destination3.position;
			
		} else if (CubePosition.rcubenumber3 == 4) {
			distance1 = Vector3.Distance (Origin.position, destination4.position);
			VecDestination1 = destination4.position;
			
		} else if (CubePosition.rcubenumber3 == 5) {
			distance1 = Vector3.Distance (Origin.position, destination5.position);
			VecDestination1 = destination5.position;
			
		} else if (CubePosition.rcubenumber3 == 6) {
			distance1 = Vector3.Distance (Origin.position, destination6.position);
			VecDestination1 = destination6.position;
		}
		
		
		
		
		LineLeft1.SetPosition (0, Origin.position); 
		LineLeft1.SetWidth (10.0f, 10.0f);
		
		//distance1 = Vector3.Distance (Origin.position, destination4.position); 
		
		// LineLeft1.SetColors (yellow, yellow); 
		
		if (counter1 < distance1) { 
			counter1 += .1f / LineDrawSpeed; 
			
			float x = Mathf.Lerp (0, 20, counter1); 
			Vector3 pointA = Origin.position; 
			// Vector3 VecDestination = destination4.position; 
			
			Vector3 pointAlongLine1 = x * Vector3.Normalize (VecDestination1 - pointA) + VecDestination1;
			
			LineLeft1.SetPosition (1, pointAlongLine1); 
			
		}
	}
	
	void Update () {
		
		
		
		//		if (counter1 < distance1){ 
		//			counter1 += .1f/LineDrawSpeed; 
		//
		//			float x = Mathf.Lerp(0,20,counter1); 
		//			Vector3 pointA = origin.position; 
		//			Vector3 pointB = destination4.position; 
		//
		//			Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA)+ pointB;
		//
		//
		//			LineLeft1.SetPosition(4,pointAlongLine); 
		//	
		//		}

	}
}
