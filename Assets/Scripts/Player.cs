using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigPlayer; // Referenciando o RigidDbody2D
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        //rigPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {


    }


}
