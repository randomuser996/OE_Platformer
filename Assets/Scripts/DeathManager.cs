using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeathManager : MonoBehaviour
{

    public int deaths = 0;
    public TextMeshProUGUI DeathText;


    private void Update()
    {
        DeathText.text = string.Format("Kys amount: {0}", deaths);
    }
}
