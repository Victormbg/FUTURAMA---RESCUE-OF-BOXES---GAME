using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{

	public int energyMAX;
	public int point;
	public float velocidade = 10f;
	public float moveX = 0f; // mover no eixo X
	
	Rigidbody2D rigidBody2D; // Fisica 2D - Corpo Rigido
	
	void Start()
	{
		rigidBody2D = GetComponent<Rigidbody2D> ();
	}

	void Update () 
	{
			moveX = Input.GetAxis ("Horizontal");
			rigidBody2D.velocity = new Vector2 (moveX * 0, rigidBody2D.velocity.y);
			
			if (Input.GetKeyDown (KeyCode.W)) 
			{
				rigidBody2D.AddForce(new Vector2(0,0), ForceMode2D.Impulse);
			}
	
		Debug.Log ("PONTOS " + point);

	}
  }