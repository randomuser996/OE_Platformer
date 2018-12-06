using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    //Detta script var ett fusk som jag gjorde snabbt för att kunna klara mina egna banor snabbare och lättare,
    //detta har inget med spelet och göra ifall att jag glömmer att deleta detta script.
    private Rigidbody2D rbody;
    private float dashTime;
    private int direction;

    public float dashSpeed;
    public float startDashTime;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    private void Update()
    {
        if(direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                direction = 2;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                direction = 3;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
                direction = 4;
        }
        else
        {
            if(dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rbody.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;
            }

            if(direction == 1)
            {
                rbody.velocity = Vector2.left * dashSpeed;
            }
            else if(direction == 2)
            {
                rbody.velocity = Vector2.right * dashSpeed;
            }
            else if (direction == 3)
            {
                rbody.velocity = Vector2.up * dashSpeed;
            }
            else if (direction == 4)
            {
                rbody.velocity = Vector2.down * dashSpeed;
            }
        }
    }
 }

