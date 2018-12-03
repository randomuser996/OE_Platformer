using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public bool isLeft = true;

    //Hämtar RigidBody och länkar den till ''rbody''.
    private DeathManager dm;
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Kollar så att ifall det funkar, alltså om man trycker H så triggerar det Move funktionen så att man kan
        //manuellt byta håll på fienden.
        if(Input.GetKeyDown(KeyCode.H))
        {
            Move(true);
        }
    }
    //Detta gör så att snigeln(fienden) roterar håll och åker åt andra hållet. Alltså 
    void Move(bool flip)
    {
        if(flip == true)
        {
            isLeft = !isLeft;
        }
        if (isLeft == true)
        {          
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    }
}
