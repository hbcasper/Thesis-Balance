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
//	public bool rightSetting; // input of pixi compared to the instruction, effects the READY -Button
	public static string strIn;

	void Start () {
		calculatedBalance = GameObject.Find ("Scale"); 
		CalculatedBalance = calculatedBalance.GetComponent<ArduinoInputBehavior> (); 
		OpenConnection();
		sp.Write ("AH");
		Debug.Log ("Connection Open");
		strIn = sp.ReadLine(); // <--- if is only in start, if the person/kid change the position it will not recognize it. It have to be update or a while, I think
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
//------------------Still necessary??
//	void ReceiveInput (){
//		// receive 4 bytes 1 = position 1;  2 = color 1; 3 = position 2; 4 = color 2
//		// position = 1 - 6 
//		// color code  A = yellow;  R = Red; V = Green
//
//	}
//-----------------

	public void OpenConnection(){
		if (sp != null) 
		{
			if (sp.IsOpen) 
			{
				sp.Close();
				sp.ReadTimeout = 50; 
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
		sp.Write ("AH");
		sp.Close();
	}

	void Update (){

		try
		{ 
			//Debug.Log(Convert.ToUInt64(Arduinovalues));
			strIn = sp.ReadLine(); //first value colo(Color left side, Place left side ; Color right side, Place right side)
//			strIn = sp.ReadLine();
//			print(strIn);
		}
		catch (Exception e){Debug.Log ("NotWorking");}
	
	}

	
}
