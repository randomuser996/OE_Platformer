using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  //<- "namespace"
//using UnityEngine.UI
    //TMPro hämtar så att TextMeshPro kan användas och sen linkar man bara detta till en TextMeshPro som visas på skärmen.

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int totalScore;

    private void Update()
    {
        //totalscore multipliceras varje gång e´n diamant är tagen.
        scoreText.text = string.Format("Score: {0}", totalScore);
    }
}
