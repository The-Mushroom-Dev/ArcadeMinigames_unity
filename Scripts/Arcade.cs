using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcade : MonoBehaviour
{
    public Manager mng;
    public AudioSource notify;
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            mng.AblePlay = true;
            notify.Play();
        }
    }
    void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            mng.AblePlay = false;
        }
    }
}
