using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //Två variabler som är standardvärdena som sedan ändras.
    public float moveSpeed = 1f;
    public bool isLeft = true;

    //Hämtar RigidBody och länkar den till ''rbody''. Privat = bara för det här skriptet.
    private Rigidbody2D rbody;

    // Use this for initialization
    //Varje gång spelet startar så hämtas Rigidbody2d och Move är falsk.
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Kollar så att ifall det funkar, alltså om man trycker H så triggerar det Move funktionen så att man kan
        //manuellt byta håll på fienden. Alltså en liten fusk kod, bra att komma ihåg att ta bort om man släpper
        //sitt spel ut i the public.
        if(Input.GetKeyDown(KeyCode.H))
        {
            Move(true);
        }
    }
    //(Kommenterar den mesta koden under här uppe) Skapar en bool "flip" i Move funktionen. Som när flip är lika med
    //true så är isLeft true också. Så om isLeft true så ändras 
    void Move(bool flip)
    {
        if(flip == true)
        {
            isLeft = !isLeft;
        }
        if (isLeft == true)
        {          
            //rbody.velocity säger till fiendens rigidbody att öka kraft
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    //Som jag sagt flera gånger i alla script så om collidern triggeras av collision taggen som är satt på de onsynliga väggen
    //vilket är "InvisibleWall" så blir Move då sann och byter håll.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    }
}
