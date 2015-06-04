using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;

public class vibration : MonoBehaviour {
	public int count = 0;
	public static SerialPort sp = new SerialPort("/dev/tty.usbmodem1431", 9600, Parity.None, 8, StopBits.One); //Find out exact serialport name with ls /dev/tty.*
	private static byte[] fingerOutputArray = new byte[24] {/*outer collide:*/ 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, /*outer leave:*/ 0x7, 0x8, 0x9, 0xA, 0xB, 0xC, /*inner collide:*/ 0xD, 0xE, 0xF, 0x10, 0x11, 0x12, /*inner leave:*/ 0x13, 0x14, 0x15, 0x16, 0x17, 0x18};
//	private int[] dataToSend = new int[3];
	private Dictionary<string, int> dataToSend = new Dictionary<string, int>();

	void Start () {
		OpenConnection();
		dataToSend.Add("innerOrOuter", 0);
		dataToSend.Add("finger", 0);
		dataToSend.Add("inOrOut", 0);
	}

//	private void sendData(int[] dataToSend){
	private void sendData(Dictionary<string, int> dataToSend){
//		int innerOrOuter = dataToSend[0];
//		int finger = dataToSend[1];
//		int inOrOut = dataToSend[2];

//		byte send = (byte)finger;

//		if (inOrOut.Equals (0)){ // leaving shape
//			send = send + 0x6;
//		}
//		if (innerOrOuter.Equals (1){ // inner shape
//			send = send + 0xC;
//		}
		byte send = (byte)dataToSend["finger"];

		if (dataToSend["inOrOut"].Equals(0)){ // leaving shape
			send += 0x6;
		}
		else if (dataToSend["innerOrOuter"].Equals(1)){ // inner shape
			send += 0xC;
		}

		print(send);
		sp.Write(fingerOutputArray, send, 1);

//		sp.Write(fingerOutputArray, isOn ? finger-1 : finger-1+6, 1);
	}

	void OnTriggerEnter(Collider other){
		if(other.name.Equals("Outer")){
			gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
		else if (other.name.Equals("Inner")){
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
		print("entering: ");
		print(other.name);
		print(gameObject.name);

		if(other.name.Equals("Outer")){
//			dataToSend[0] = 0;
			dataToSend["innerOrOuter"] = 0;
		}
		else if(other.name.Equals("Inner")){
//			dataToSend[0] = 1;
			dataToSend["innerOrOuter"] = 1;
		}

		if(gameObject.name.Equals("finger_01")){
////			sendData(1, 1);
//			dataToSend[1] = 1;
//			dataToSend[2] = 1;
			dataToSend["finger"] = 1;
			dataToSend["inOrOut"] = 1;
		}
		else if(gameObject.name.Equals("finger_02")){
//			//			sendData(2, 1);
//			dataToSend[1] = 2;
//			dataToSend[2] = 1;
			dataToSend["finger"] = 2;
			dataToSend["inOrOut"] = 1;
		}
		else if(gameObject.name.Equals("finger_03")){
			//			sendData(3, 1);
//			dataToSend[1] = 3;
//			dataToSend[2] = 1;

			dataToSend["finger"] = 3;
			dataToSend["inOrOut"] = 1;
		}
		else if(gameObject.name.Equals("finger_04")){
			//			sendData(4, 1);
//			dataToSend[1] = 4;
//			dataToSend[2] = 1;

			dataToSend["finger"] = 4;
			dataToSend["inOrOut"] = 1;
		}
		else if(gameObject.name.Equals("finger_05")){
			//			sendData(5, 1);
//			dataToSend[1] = 5;
//			dataToSend[2] = 1;

			dataToSend["finger"] = 5;
			dataToSend["inOrOut"] = 1;
		}
		else if(gameObject.name.Equals("Palm")){
			//			sendData(6, 1);
//			dataToSend[1] = 6;
//			dataToSend[2] = 1;

			dataToSend["finger"] = 6;
			dataToSend["inOrOut"] = 1;
		}
		sendData(dataToSend);
	}

	void OnTriggerExit(Collider other){
		if(other.name.Equals("Outer")){
			gameObject.GetComponent<Renderer>().material.color = Color.white;
		}
		else if (other.name.Equals("Inner")){
			gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
		print("leaving: ");
		print(other.name);
		print(gameObject.name);
		if(gameObject.name.Equals("finger_01")){
			//			sendData(1, 0);
//			dataToSend[1] = 1;
//			dataToSend[2] = 0;

			dataToSend["finger"] = 1;
			dataToSend["inOrOut"] = 0;
		}
		else if(gameObject.name.Equals("finger_02")){
			//			sendData(2, 0);
//			dataToSend[1] = 2;
//			dataToSend[2] = 0;
			dataToSend["finger"] = 2;
			dataToSend["inOrOut"] = 0;
			}
		else if(gameObject.name.Equals("finger_03")){
			//			sendData(3, 0);
//			dataToSend[1] = 3;
//			dataToSend[2] = 0;
			dataToSend["finger"] = 3;
			dataToSend["inOrOut"] = 0;
			}
		else if(gameObject.name.Equals("finger_04")){
			//			sendData(4, 0);
//			dataToSend[1] = 4;
//			dataToSend[2] = 0;
			dataToSend["finger"] = 4;
			dataToSend["inOrOut"] = 0;
			}
		else if(gameObject.name.Equals("finger_05")){
			//			sendData(5, 0);
//			dataToSend[1] = 5;
//			dataToSend[2] = 0;
			dataToSend["finger"] = 5;
			dataToSend["inOrOut"] = 0;
			}
		else if(gameObject.name.Equals("Palm")){
			//			sendData(6, 0);
//			dataToSend[1] = 6;
//			dataToSend[2] = 0;
			dataToSend["finger"] = 6;
			dataToSend["inOrOut"] = 0;
			}
			sendData(dataToSend);
	}

	public static void OpenConnection() {
		if (sp != null) {
			print("exists");
			if (sp.IsOpen) {
				print("open");
			}
			else {
				print("not open");
				sp.Open();  // opens the connection
				sp.ReadTimeout = 100;  // sets the timeout value before reporting error
			}
		}
		else {
			if (sp.IsOpen) {
				print("Port is already open");
			}
			else {
				print("Port == null");
			}
		}
	}
}