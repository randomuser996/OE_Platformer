using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    //I private void så finns funktionen OnCollisionEnter2D, alltså om något kolliderar med ett objekt med detta scriptet
    //så händer all kod under
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Men då måste det som kolliderar med ha taggen "Player" för att koden därunder ska hända.
        //Om taggen "Player" kolliderar med vad detta scriptet är länkat till så händer all kod under, alltså printen
        //och att scenen laddar om.
        if (collision.gameObject.tag == "Player")
        {
            print("Kys");
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
            
        }
    }
}
