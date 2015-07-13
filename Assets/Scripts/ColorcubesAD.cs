﻿using UnityEngine;
using System.Collections;
using System.Text;
using System;
using UnityEngine.UI;

public class ColorcubesAD : MonoBehaviour {


	Seecubes[] activecubes;
	public int totalLeft = 0;
	public int totalRight = 0;
	public int difference;

	public string Leftcubes;
	public string Rightcubes;

	public GameObject Scale;
	Instruction DifficultyConfiguration;

	public void Start(){
		activecubes = gameObject.GetComponentsInChildren<Seecubes> ();

		DifficultyConfiguration = Scale.GetComponent<Instruction> ();
	}


	public void ActiveCubesAD() {

		Leftcubes = Generatecubespositions ();
		Rightcubes = Generatecubespositions ();

		if (DifficultyConfiguration.side == 1) {
			Leftcubes = Rightcubes;
		}
		if (DifficultyConfiguration.side ==2) {
			if (Leftcubes == Rightcubes){
				Rightcubes = Generatecubespositions ();
			}
		}
		foreach (Seecubes script in activecubes) {
			script.ActiveCubesAD ();

		}
		checkcolors ();
		foreach (Seecubes script in activecubes) {
			script.paintcube ();
			
		}
		CalculateWeight();
		gameObject.GetComponent<RegisterActiveCubes> ().Checkcubes ();

			
		}
	public void checkcolors(){
		bool correct=false;
	
		bool existared= false;
		bool existayellow=false;
		foreach (Seecubes script in activecubes) {
			
			if (script.cubeColor==1){
				existayellow=true;
				
				
			} else if (script.cubeColor==2){
				existared=true;
			}
		}
		if (DifficultyConfiguration.numberofcolors == 2 && existayellow==true && existared==true) {
			correct = true;
		}
		while(correct = false){
			ActiveCubesAD();
			if (DifficultyConfiguration.numberofcolors == 2 && existayellow==true && existared==true) {
			correct = true;
		}

	}


		
	}


		

		public void DeactiveCubesAD() {
		totalLeft = 0;
		totalRight = 0;
			
			foreach (Seecubes script in activecubes) {
				
				script.NoActiveCubesAD();

			}
	}

	public void CalculateWeight(){
		totalLeft = 0;
		totalRight = 0;
		difference = 0;
		foreach (Seecubes script in activecubes) {
			
			if (script.gameObject.tag == ("Left")) {
				totalLeft = totalLeft + script.myValue;
			}
			if (script.gameObject.tag == ("Right")) {
				totalRight = totalRight + script.myValue;
				
			}
			
		}
		
		if (totalLeft > totalRight) {
			
			difference = totalLeft - totalRight;
		} else if (totalLeft < totalRight) {
			
			difference = totalRight - totalLeft;
		} else {
			difference = 0;
		}
		Debug.Log (totalLeft+","+ totalRight+","+ difference);
	}



		
	public string Generatecubespositions()  {
			
			string input = "123456";
			StringBuilder activecubes = new StringBuilder();
			char ch;
			for (int i = 0; i < DifficultyConfiguration.numberofplaces; i++)
			{
				
				ch = input[UnityEngine.Random.Range(0, input.Length-1)];
				activecubes.Append(ch);
				input = input.Replace(ch.ToString(),string.Empty);
				
			}
			return activecubes.ToString();
			
		}



}
