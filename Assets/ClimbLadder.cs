using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbLadder : MonoBehaviour
{
    public float moveSpeed;
    public LayerMask ladderMask;
    public enum detectionModes
    {
        layerMask, tag
    }
    public detectionModes detectionMode;

    private float inputHorizontal, inputVertical;
    private Rigidbody2D rbody;
    private bool isClimbing = false;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        rbody.velocity = new Vector2(inputHorizontal * moveSpeed, 0f);
        //Om boolean isClimbing är true alltså om vi klättrar på stegen så händer koden
        //vilket gör så att gravityscale är 0 och rigidbodysen för att vi ska kunna röra oss ner och upp
        //men om vi kommer av stegen så stängs det av. Detta gör så att man kan åka upp och ner för stegen.
        //Alltså då med Y axeln.
        if (isClimbing)
        {
            rbody.gravityScale = 0f;
            rbody.velocity = new Vector2(inputHorizontal * moveSpeed, inputVertical * moveSpeed);
        }
        else
        {
            rbody.gravityScale = 5;
        }

        //Kollar om man är på laddern via layermask.
        if (detectionMode == detectionModes.layerMask)
        {
            //Om rigidbody rör laddermask så är climbing true, men om inte så är det false.
            //Gör så att det inte är hela tiden. 
            if (rbody.IsTouchingLayers(ladderMask))
            {
                isClimbing = true;
            }
            else
            {
                isClimbing = false;
            }
        }
    }

    //Jag har redan förklarat detta i många andra scripts men om Triggern går av, alltså
    //från box collidern som är en trigger (den måste gå av från collision.tag ladder) så händer koden
    //så att isclimbing = true. Och isclimbing grejen är skapad så att när man är på stegen så kan man
    //röra sig upp och ned utan med hjälp av taggen och layern den har för att identifiera den.
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (detectionMode == detectionModes.tag)
        {
            if (collision.tag == ("Ladder"))
            {
                isClimbing = true;
            }
        }
    }

    //Och detta säger basically bara att om man inte är på "Ladder" så händer inget.
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == ("Ladder"))
        {
            isClimbing = false;
        }
    }
}
