using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public int touches; 

    // Detta gör så att varje gång något triggerar, alltså att något rör objektet med detta scriptet på
    // så säger detta att det rör +1 till objekt.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touches++;
    }
    // Samma sak här som ovan fast med -1 till objekt.
    private void OnTriggerExit2D(Collider2D collision)
    {
        touches--;
    }
}