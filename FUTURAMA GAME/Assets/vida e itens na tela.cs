using System.Collections;
using System.Collections.Generic;
using UnityEngine;

var vida = 100;
var slot1 = "";
var slot2 = "";

public class vidaeitensnatela : MonoBehaviour {

	function OnGUI(){
		GUI.Label (Rect (10,10,80,20), "Itens:");
		GUI.TextField (Rect (90,10,65,20), slot1.ToString());
		GUI.TextField (Rect (160,10,65,20), slot2.ToString());
		GUI.Label (Rect (10,30,80,20), "Vida:");
		GUI.TextField (Rect (90,30,80,20), vida.ToString());
	}

	// Use this for initialization

	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
