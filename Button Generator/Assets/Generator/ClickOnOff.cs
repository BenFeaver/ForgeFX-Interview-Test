using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundSequence : MonoBehaviour
{
    public bool Idle = false;
    public AudioSource clickOn;
    public AudioSource clickOff;
    void OnMouseDown()
    {
        if (Idle == false)
        {
            Debug.Log("On");
            Idle = true;
            clickOn.Play();
            return;
        }
        if (Idle == true)
        {
            Debug.Log("Off");
            Idle = false;
            clickOff.Play();
            return;
        }
    }
    
}
