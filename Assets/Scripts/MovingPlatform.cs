using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    float dirX, moveSpeed = 1.5f;
    bool moveRight = true;

    private void Update()
    {
        //Om positionen är på x 24 så kommer den åka tillbaka åt andra hållet
        if (transform.position.x > 24f)
        {
            moveRight = false;
        }
        //Samma sak som ovanför, detta gör bara så att när den kommer till 16,5 i x värdet så byter den håll.
        if (transform.position.x < 16.5f)
        {
            //Den gör detta med moveRight boolen som händer nedanför.
            moveRight = true;
        }

        //Alltså om moveRight kallas, alltså när den nuddar 16,5f i x värdet så blir moveright true alltså händer
        //koden under här. 
        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }

    }
}
