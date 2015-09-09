using UnityEngine;
using System.Collections;
using UnityEditor;

public class Dev_Previsor_RoomZones : MonoBehaviour {

	public bool[] zones;
	private string[]zoneNames;

	void Start () {
		zones = new bool[5];
		zoneNames = new string[5]{"Küche","Bad","Wc","Empfang","Büro"};


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
