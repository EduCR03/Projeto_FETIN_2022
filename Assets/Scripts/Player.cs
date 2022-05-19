using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigPlayer; // Referenciando o RigidDbody2D
    public int speed;
    public int jumpForce;
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

    void Move()
    {
        // retornando -1 esquerda, 1 direita
        float movement = Input.GetAxis("Horizontal");
        // Mudando a velocidade de acordo com o valor de movement 
        rigPlayer.velocity = new Vector2(movement * speed, rigPlayer.velocity.y);


    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigPlayer.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

}
