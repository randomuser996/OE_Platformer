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
        //visual sake.
        GetComponent<SpriteRenderer>().enabled = false;

    }
}
