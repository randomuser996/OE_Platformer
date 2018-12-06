using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Skapar en funktion som laddar nästa scen i que'n som man kan hitta i build settings. Jag satte 
    //Que'n på Menu - Tutorial - Samplescene, så när den här funktionen används går t.e.x från menyn
    //till Tutorial, osv.
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Samma sak här, skapar en funktion fast för att spelet ska stängas. Debuggen finns för att se
    //att det funkar, för jag kan inte se om det funkar utan att starta spelet, alltså utanför editorn.
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
