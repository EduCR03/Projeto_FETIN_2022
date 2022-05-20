using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigPlayer; // Referenciando o RigidDbody2D
    public int speed;
    public int jumpForce;
    
    private bool Jumping; //variavel p/ pulando

    // Start is called before the first frame update
    void Start()
    {
        rigPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Jump();
    }

    //movimento
    void Move()
    {
        // retornando -1 esquerda, 1 direita
        float movement = Input.GetAxis("Horizontal");
        // Mudando a velocidade de acordo com o valor de movement 
        rigPlayer.velocity = new Vector2(movement * speed, rigPlayer.velocity.y);

        if(movement > 0)
        {
            //personagem virado pra direita
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if(movement < 0)
        {
            //personagem virado pra esquerda
            transform.eulerAngles = new(0, 180, 0);
        }


    }

    //pulo
    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(!Jumping)
            {
                //fazendo o personagem pular de acordo com o valor da "jumpForce"
                rigPlayer.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);  
                
                Jumping = true; //está pulando

            }

        }
    }

    private void OnCollisionEnter2D(Collision2D structureColl)
    {
        if(structureColl.gameObject.layer == 6) //se houver a colisão
        {
            Jumping = false; //o personagem pode pular
        }
    }




}
