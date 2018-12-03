using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    //När triggern går av, asså av att något rör den så händer följande kod under...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Men det händer bara om kollisionstaggen är "Player" som är nära toppen av inspectorn när objektet är valt.
        //Alltså man hittar taggen där uppe, det är den som är linkat till spelaren som gör då att om spelaren rör
        //detta objektet så händer koden där under. Vilket då är att något printas i konsollen och sen förstör gameobject.

        //Detta skriptet är för att jag orkar inte med fienderna så man kan lätt döda dem genom att hoppa på snigelns snäcka.
        //Detta skriptet är ju också länkat till RatTrap grejen med InvisibleWalls med en trigger box collider som då om man
        //träffar så händer denna koden.
        if (collision.tag == "Player")
        {
            print("Enemy killed");
            Destroy(gameObject);  
        }
    }
}
