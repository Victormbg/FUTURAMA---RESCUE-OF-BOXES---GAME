using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogadormovimentosbasicos : MonoBehaviour {

	var velocidadeFrente :50f float;
	var velocidadeLado   :40f float;
	var velocidadeCima   :50f float;
	var velocidadeTras   :50;

	Function Start () {

	}

	Function Update () {

		velocidadeFrente = 50*Time.deltaTime; //Velocidade para a Frente
		velocidadeTras   = 40*Time.deltaTime;  //Velocidade para Atras
		velocidadeLado   = 60*Time.deltaTime;  //Velocidade para os Lados


		if (Input.GetKey("w")) //Andar para a Frente
		{
			transform.Translate(0,0,velocidadeFrente);
		}

		if (Input.GetKey("s")) //Andar para a Atras
		{
			transform.Translate(0,0,-velocidadeTras);
		}

		if (Input.GetKey("a")) //Andar para a Esquerda
		{
			transform.Translate(-velocidadeLado,0,0);
		}

		if (Input.GetKey("d")) //Andar para a Direita
		{
			transform.Translate(velocidadeLado,0,0);
		}


	}

}