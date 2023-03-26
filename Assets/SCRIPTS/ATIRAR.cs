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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class atirar : MonoBehaviour
{


    [Header("Gun Configuration")]
    public float damage;
    public float range;
    public float firerate;
    public float waitToFirerate;
    public Camera cam;
    public ParticleSystem ammoParticle;
    public GameObject impact;
    public bool hold = false;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            hold = true;


        if (Input.GetButtonUp("Fire1"))
            hold = false;


        if (hold == true)
            waitToFirerate += 1;


        if (waitToFirerate > firerate)
            Shoot();
    }


    void Shoot()
    {


        waitToFirerate = 0;
        ammoParticle.Play();
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log("Mirando em: " + hit.transform.name);


            GameObject impactGO = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }

}