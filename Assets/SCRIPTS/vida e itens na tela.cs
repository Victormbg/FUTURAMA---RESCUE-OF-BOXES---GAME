using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaeitensnatela : MonoBehaviour {

    int vida = 100;
    string slot1 = "";
    string slot2 = "";

    void OnGUI(){
		GUI.Label (RectInt (10,10,80,20), "Itens:");
		GUI.TextField (RectInt(90,10,65,20), slot1.ToString());
		GUI.TextField (RectInt(160,10,65,20), slot2.ToString());
		GUI.Label (RectInt(10,30,80,20), "Vida:");
		GUI.TextField (RectInt(90,30,80,20), vida.ToString());
	}

    private Rect RectInt(int v1, int v2, int v3, int v4)
    {
        throw new NotImplementedException();
    }

    // Use this for initialization

    void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
