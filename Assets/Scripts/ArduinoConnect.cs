using UnityEngine;
using System.Collections;
using System.IO.Ports; 

//
public class ArduinoConnect : MonoBehaviour {



	public static SerialPort sp = new SerialPort("COM1", 9600);
	int Balanceresult=0;
//
//	private ArduinoInputBehavior BalanceVar;
//	public GameObject balanceVar;
//
//	public bool rightSetting; // input of pixi compared to the instruction, effects the READY -Button
//	public static string strIn;
//
//	// Use this for initialization
void Start () {

		sp.Open ();
		sp.ReadTimeout= 1;
//
		OpenConnection();
//		balanceVar = GameObject.Find ("Scale");
//		BalanceVar = balanceVar.GetComponent<ArduinoInputBehavior> (); 
//
	}
//	
//	// Update is called once per frame
		void Update () {
		if (sp.IsOpen) {
			try {
				MoveScale (sp.ReadByte ());
				print (sp.ReadByte ());
			} catch (System.Exception) {
				throw;
			}
			
//		strIn = sp.ReadLine();
//		print(strIn);
		}
	}

		void MoveScale(int Direction){
		if (Direction == 1) {
			Debug.Log ("R");
		}
		if (Direction == 2) {
			Debug.Log ("L");
		}
	}


//
//	void ReceiveInput (){
//		// receive 4 bytes 1 = position 1;  2 = color 1; 3 = position 2; 4 = color 2
//		// position = 1 - 6 
//		// color code  A = yellow;  R = Red; V = Green
//
//	}
//
//
	void ScaleMove ()
	{
		if (Balanceresult == 1) {

			sp.Write("AL"); //why that values?????
			
		} else if (Balanceresult== 2) {

			sp.Write ("AR");
			
		} else if (Balanceresult == 0)
		{
			sp.Write ("AH");  
		}
	}

public void OpenConnection() 
	{
		if (sp != null) 
		{
			if (sp.IsOpen) 
			{
				sp.Close();
				print("Closing port, because it was already open!");
			}
			else 
			{
				sp.Open();  // opens the connection
				sp.ReadTimeout = 50;  // sets the timeout value before reporting error
				print ("Port Opened!");
			}
		}
		else 
		{
			if (sp.IsOpen)
			{
				print("Port is already open");
			}
			else 
			{
				print("Port == null");
			}
		}
	}
	
	void OnApplicationQuit() 
	{
		sp.Close();
	}

}
