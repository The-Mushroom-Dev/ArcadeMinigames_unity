using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Maingame;
    public GameObject Minigame;
    public GameObject canvas;
    bool isPlaying;
    public bool AblePlay;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && !isPlaying && AblePlay)
        {
            Minigame.SetActive(true);
            Maingame.SetActive(false);
            isPlaying = !isPlaying;
            AblePlay = !AblePlay;
        }
        else if(Input.GetKeyDown(KeyCode.E) && isPlaying)
        {
            Minigame.SetActive(false);
            Maingame.SetActive(true);
            isPlaying = !isPlaying;
        }
        if(AblePlay == true)
        {
            
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
        
    }
}
