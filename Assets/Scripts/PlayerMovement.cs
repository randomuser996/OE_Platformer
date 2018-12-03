using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Endast ett värde emellan 0-20, alltså värdet kan ej bli högre eller lägre
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;

    //Länkar rigidbody till rbody, samma sak med groundcheck i sammanhang med ett annat script.
    //Private gör också så att man inte kan komma åt det i något annat script, bara i detta.
    public GroundCheck groundCheck;
    private Rigidbody2D rbody;

	// Use this for initialization
	void Start ()
    {
        //Rbody referar nu till 
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        {
            //Vektor 2 = ett X och ett Y värde
            rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

            if(Input.GetKeyDown(KeyCode.Space))
            {
                //Om man rör mer än 0 grejer så kan man hoppa, detta är säkerställer och gör så att man inte kan dubbelhoppa.
                //skulle dock kunna göras till en funktion i spelet.
                if (groundCheck.touches > 0)
                {
                    
                    rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
                }
            }
        }
    }
}
