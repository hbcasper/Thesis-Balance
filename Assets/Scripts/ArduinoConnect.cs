using UnityEngine;
using System.Collections;
using System;
using System.IO.Ports; 
using System.Threading;

//
public class ArduinoConnect : MonoBehaviour {

	private ArduinoInputBehavior CalculatedBalance;
	private GameObject calculatedBalance;

	int Arduinovalues;

	public static SerialPort sp = new SerialPort("COM5", 9600);
//
//	private ArduinoInputBehavior BalanceVar;
//	public GameObject balanceVar;
//
//	public bool rightSetting; // input of pixi compared to the instruction, effects the READY -Button
	public static string strIn;
//
//	// Use this for initialization

	void Start () {

	//	sp.Open ();
	//	sp.ReadTimeout= 1;

		calculatedBalance = GameObject.Find ("Scale"); 
		CalculatedBalance = calculatedBalance.GetComponent<ArduinoInputBehavior> (); 
//
//		gameObject.GetComponent<Renderer>().material.color = Color.black;
		OpenConnection();
		sp.Write ("AH");
		Debug.Log ("Connection Open");
		strIn = sp.ReadLine();

//		balanceVar = GameObject.Find ("Scale");
//		BalanceVar = balanceVar.GetComponent<ArduinoInputBehavior> (); 
//
	}


	public void InputArduino(){

//		string s = [strIn];
//		string[] values = s.Split(',');
		print(strIn);
	}

	public void OutputForArduino(){

		if (CalculatedBalance.balance == 1) {
			sp.Write ("AL"); 
			Debug.Log ("Sent AL");
		} else if (CalculatedBalance.balance == 2) {
			sp.Write ("AR");
			Debug.Log ("Sent AR");

		} else {
			sp.Write ("AH");
			Debug.Log ("Sent AH");

		}
	
	}

	public void MoveBackHome(){

		sp.Write ("AH");

	}
//	
//	// Update is called once per frame
		public void Testarduino () {
//			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;
		//	sp.Write ("R");

//		if (sp.IsOpen) {
//			try {
//				MoveScale (sp.ReadByte ());
//				print (sp.ReadByte ());
//			} catch (System.Exception) {
//				throw;
//			}
			
//		strIn = sp.ReadLine();
//		print(strIn);
		}


//		void MoveScale(int Direction){
//		if (Direction == 1) {
//			Debug.Log ("R");
//		}
//		if (Direction == 2) {
//			Debug.Log ("L");
//		}
//	}


//
//	void ReceiveInput (){
//		// receive 4 bytes 1 = position 1;  2 = color 1; 3 = position 2; 4 = color 2
//		// position = 1 - 6 
//		// color code  A = yellow;  R = Red; V = Green
//
//	}
//
//

	public void OpenConnection(){
		if (sp != null) 
		{
			if (sp.IsOpen) 
			{
				sp.Close();
				sp.ReadTimeout = 50; 
				print("Closing port, because it was already open!");
				gameObject.GetComponent<Renderer>().material.color = Color.cyan;

			}
			else 
			{
				sp.Open();  // opens the connection
				sp.ReadTimeout = 50;  // sets the timeout value before reporting error
//				gameObject.GetComponent<Renderer>().material.color = Color.green;
				print ("Port Opened!");

			}
		}
		else 
		{
			if (sp.IsOpen)
			{
				print("Port is already open");
				gameObject.GetComponent<Renderer>().material.color = Color.yellow;
			}
			else 
			{
				print("Port == null");
				gameObject.GetComponent<Renderer>().material.color = Color.red;
			}
		}
	}
	
	void OnApplicationQuit() 
	{
		sp.Write ("AH");
		sp.Close();
	}

	void Update (){

		try
		{
		
			Arduinovalues = sp.ReadByte(); //first value colo(Color left side, Place left side ; Color right side, Place right side)
			//Debug.Log(Convert.ToUInt64(Arduinovalues));
			strIn = sp.ReadLine();

//			strIn = sp.ReadLine();
//			print(strIn);
		}
		catch (Exception e){Debug.Log ("NotWorking");}
	
	}

	
}
