using System;
namespace AssemblyCSharp
var bala : GameObject;

{
	function Start () {

	}

	function Update () { 

		if ( Input.GetMouseButtonDown (0) )

		{


			Instantiate (bala,transform.position,transform.rotation) ;


		}

	}

	Bala:

	#pragma strict

	var velocidadeBalaPistol : float ;

	function Start () {

		velocidadeBalaPistol= 10*Time. deltaTime;

	}

	function Update () {

		transform.Translate(0,0,velocidadeBalaPistol);

	}


}

