using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryRoyale : MonoBehaviour
{
    public string levelToLoad = "SampleScene";

    //Innuti voiden så är funktionen OnTriggerEnter2D, jag sa detta innan i ett annat script men
    //det gör så att varje gång triggern går av vid kollision så går följande kod av.
    //Men eftersom det står ''if collisiontag=player'' grejen så måste objektets tag vara "player''
    //för att nästa kod ska gå av. Vilket är då printen och att scenen laddar.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            print("#1 VICTORY ROYALE");
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
