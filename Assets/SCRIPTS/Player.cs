using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour 
{

    //public int energyMAX;
    public int point;
    public float aceleracao;
    float _aceleracao;
    public float move;
    //public float velocidade = 10f;
    //public float moveX = 0f; // mover no eixo X

    Rigidbody2D rigidBody2D; // Fisica 2D - Corpo Rigido


    private float velocidade;
    private Vector2 direcao;

    // Start is called before the first frame update
    void Start()
	{
        velocidade = 2;
        direcao = Vector2.zero;
        rigidBody2D = GetComponent<Rigidbody2D> ();
	}

	void Update () 
	{
        rigidBody2D.AddForce(new Vector2(_aceleracao, 0), ForceMode2D.Force);

        if (rigidBody2D.velocity.x > 25 || rigidBody2D.velocity.x < -15)
        {
            _aceleracao = 0;
        }


        InputPersonagem();
        transform.Translate(direcao * velocidade * Time.deltaTime);
        //Debug.Log("PONTOS " + point);
        /*
        moveX = Input.GetAxis ("Horizontal");
			rigidBody2D.velocity = new Vector2 (moveX * 0, rigidBody2D.velocity.y);
			
			if (Input.GetKeyDown (KeyCode.W)) 
			{
				rigidBody2D.AddForce(new Vector2(0,0), ForceMode2D.Impulse);
			}
	
		Debug.Log ("PONTOS " + point);
        */
    }

    void InputPersonagem()
    {
        direcao = Vector2.zero;


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, move * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -move * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao += Vector2.right;
        }
    }
}