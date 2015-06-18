using UnityEngine;
using System.Collections;
//using System.IO.Ports;

public class ArduinoInputBehavior : MonoBehaviour {

	private Instruction Instructionvalues;
	private ToogleOptions GameConfiguration;
	private GameObject GameConfigurationToogles;
	private GameObject Cubesparent;
	private ColorcubesAD Colorcubes;

	public GameObject Objeto;

	public int balance = 0;
	public int leftpos1; 
	public int leftpos2; 
	public int rightpos1; 
	public int rightpos2; 
	public int leftW1Red; 
	public int leftW2Yell; 
	public int rightW1Red;
	public int rightW2Yell;

	public bool pushbutton = false;
	public int whichbutton = 0; 

	
	// SerialPort arduinoinput = new SerialPort("COMX", 9600);

	// Use this for initialization
	void Start () 
	{
		GameConfigurationToogles = GameObject.Find ("GameConfiguration");
		GameConfiguration = GameConfigurationToogles.GetComponent<ToogleOptions>();
		Cubesparent = GameObject.Find ("Invisible Spaces");
		Colorcubes = Cubesparent.GetComponent<ColorcubesAD> ();

		Instructionvalues = Objeto.GetComponent<Instruction>();
	}


	void Update ()
	{
		leftpos1 = Instructionvalues.pnl1;
		leftpos2 = Instructionvalues.pnl2;
		rightpos1 = Instructionvalues.pnr1;
		rightpos2 = Instructionvalues.pnr2;
		leftW1Red = Instructionvalues.LeftW1;
		leftW2Yell = Instructionvalues.LeftW2;
		rightW1Red = Instructionvalues.RightW1;
		rightW2Yell = Instructionvalues.RightW2;

		if (GameConfiguration.ActiveAdaptiveDificulty == false) {

			SetWeigth (leftpos1, leftpos2, rightpos1, rightpos2, leftW1Red, leftW2Yell, rightW1Red, rightW2Yell);
		}
		else if (GameConfiguration.ActiveAdaptiveDificulty == true) 
		{
			if (Colorcubes.totalLeft > Colorcubes.totalRight) {
				balance = 1;
			} 
			else if (Colorcubes.totalLeft < Colorcubes.totalRight) {
				balance = 2;
			} 
			else {
				balance = 0;
			}

		}


	}


	//balance coded for 1 = left, 2 = right, 0 = balanced
	int SetWeigth (int leftpos1, int leftpos2, int rightpos1, int rightpos2, int leftW1, int leftW2, int rightW1, int rightW2)
	{
		int powerleft = leftpos1 * leftW1 + leftpos2 * leftW2;
		int powerright = rightpos1 * rightW1 + rightpos2 * rightW2;
		balance = 0;

		if (powerleft > powerright) {
			balance = 1;
		} 
		else if (powerleft < powerright) {
			balance = 2;
		} 

		return balance;

	}

}
