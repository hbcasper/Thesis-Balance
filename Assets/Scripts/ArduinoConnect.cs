using UnityEngine;
using System.Collections;
//using System.IO.Ports; 
using System.Threading;
//
public class ArduinoConnect : MonoBehaviour {
//
//
//	private ArduinoInputBehavior BalanceVar;
//	public GameObject balanceVar;
//
//	public bool rightSetting; // input of pixi compared to the instruction, effects the READY -Button
//	public static SerialPort sp = new SerialPort("COMX//check here arduino connection", 9600);
//	public static string strIn;
//
//	// Use this for initialization
//	void Start () {
//
//		OpenConnection();
//		balanceVar = GameObject.Find ("Scale");
//		BalanceVar = balanceVar.GetComponent<ArduinoInputBehavior> (); 
//
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		strIn = sp.ReadLine();
//		print(strIn);
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
//	void ScaleMove ()
//	{
//		if (BalanceVar.balance == 1) {
//
//			SendLeft(); 
//			
//		} else if (BalanceVar.balance == 2) {
//
//			SendRight();
//			
//		} else 
//		{
//			SendBalance(); 
//		}
//	}
//
//	void SendLeft(){
//		sp.Write("AL");
//	}
//	void SendRight(){
//		sp.Write ("AR"); 
//	}
//	void SendBalance(){
//		sp.Write ("AH"); 
//	}
//
//	public void OpenConnection() 
//	{
//		if (sp != null) 
//		{
//			if (sp.IsOpen) 
//			{
//				sp.Close();
//				print("Closing port, because it was already open!");
//			}
//			else 
//			{
//				sp.Open();  // opens the connection
//				sp.ReadTimeout = 50;  // sets the timeout value before reporting error
//				print ("Port Opened!");
//			}
//		}
//		else 
//		{
//			if (sp.IsOpen)
//			{
//				print("Port is already open");
//			}
//			else 
//			{
//				print("Port == null");
//			}
//		}
//	}
//	
//	void OnApplicationQuit() 
//	{
//		sp.Close();
//	}
//
}
