using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;

    //En private void har funktionen OnTriggerEnter2D vilket gör så om objektet triggeras av att något rör det
    //så händer all kod under.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Varje gång en diamant är tagen printas det "Kys collected!" om collision tagn är player då.
        print("Coin collected!");
        if (collision.tag == "Player")
        {
            //Skapar en temporär variabel "controller" och sätt den till resultatet
            //av sökninegn efter objektet med taggen "GameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            //Om gamecontrollern finns så hoppar den till ScoreTracker o.s.v och lägger till score om båda finns.
            //Annars komm det upp ett error i konsollen, fast spelet kan fortfarande köras.
            if (controller != null)
            {
                //Skapar en temporär variabel "tracker" och sätt den till
                //resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if(tracker != null)
                {
                    tracker.totalScore += score;
                }
                //Kontrollerar så att allt funkar så man kan hitta lätt, alltså om något är fel så kommer det ett error i
                //konsollen men spelet fungerar fortfarande att spela.
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");
                }
            }
            else
            {
                Debug.LogError("GameController finns inte.");
            }
                Destroy(gameObject);
        }
    }
}