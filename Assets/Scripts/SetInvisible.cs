using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Detta gör så att varje gång spelet startar(void Start) så blir SpriteRenderern = false
        //vilket betyder att väggen blir onsynlig så att man inte ser den i spelet, så det är för
        //visual sake. För man kan se den i Unity när man programmerar spelet vilket hjälper
        //till när man programmerar, men det är nog inte så bra om det är med i spelet.
        GetComponent<SpriteRenderer>().enabled = false;

    }
}
