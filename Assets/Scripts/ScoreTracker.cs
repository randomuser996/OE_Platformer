using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  //<- "namespace"
//using UnityEngine.UI
    //TMPro hämtar så att TextMeshPro kan användas och sen linkar man bara detta till en TextMeshPro som visas på skärmen.

public class ScoreTracker : MonoBehaviour
{
    //Skapar en variabel åt TextMeshPro.
    public TextMeshProUGUI scoreText;
    public int totalScore;

    private void Update()
    {
        //Varje gång en diamant är tagen så läggs det till 1 i totalScore som läggs till i texten i spelet som spelaren ser.
        //detta är då linkat till ett annat script (Coin.cs).
        scoreText.text = string.Format("Score: {0}", totalScore);
    }
}
