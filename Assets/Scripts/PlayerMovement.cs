using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Tar rigidbodyn av objektet den är på för att den är på rigidbody2d som är kallad rbody. Och att
//detta scriptet måste ha den för att det ska fungera.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Endast ett värde emellan 0-20, alltså värdet kan ej bli högre eller lägre.
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;

    public bool doubleJump = false;

    //Länkar rigidbody till rbody, samma sak med groundcheck i sammanhang med ett annat script.
    //Private gör också så att man inte kan komma åt det i något annat script, bara i detta.
    public GroundCheck groundCheck;
    private Rigidbody2D rbody;

	// Use this for initialization
	void Start ()
    {
        //Rbody referar nu till objektets rigidbody.
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        {
            //Vektor 2 = ett X och ett Y värde
            rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

            //Här går det att ha GetButtonDown, då räknas det för kontroller också. Bra att notera om man ska göra ett crossplay
            //platforms spel så behöver man inte göra flera script för movement för olika konsoller. Utan man kan bara använda det
            //som är då inbyggt i Unity. Man kan också hitta det någonstanns i Unity och kolla bindsen.
            if(Input.GetKeyDown(KeyCode.W))
            {
                //Om man rör mer än 0 grejer så kan man hoppa, detta är säkerställer och gör så att man inte kan dubbelhoppa.
                //Skulle dock kunna göras till en funktion i spelet, men valde att inte göra en sådan funktion för det skulle
                //förstöra allt p.g.a hur mappen är skapad.
                if (groundCheck.touches > 0)
                {
                    //rbody som jag sa tidigare var refererat till objektets rigidbody så objektets rigidbody får en ny kraft
                    //två nya variabler för att bestämma 2 saker istället för 1.
                    rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
                }
            }
        }
    }
}
