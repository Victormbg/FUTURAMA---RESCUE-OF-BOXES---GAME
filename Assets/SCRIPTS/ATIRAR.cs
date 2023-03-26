/*
using System;
namespace AssemblyCSharp
var bala : GameObject;

{
	void Start () {

	}

	void Update () { 

		if ( Input.GetMouseButtonDown (0) )

		{


			Instantiate (bala,transform.position,transform.rotation) ;


		}

    }


//Bala:

#pragma strict

var velocidadeBalaPistol : float ;

	void Start () {

		velocidadeBalaPistol= 10*Time. deltaTime;

	}

	void Update () {

		transform.Translate(0,0,velocidadeBalaPistol);

	}


}
*/

using UnityEngine;

public class InstantiateObject : MonoBehaviour
{

    public GameObject spawn;

    public Transform target;

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.E))
            return;

        Instantiate(spawn, target.position, target.rotation);
    }
}
