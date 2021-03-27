using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickOnOff : MonoBehaviour
{
    public bool Idle = false; //Establish when the generator is in idle and when it is not
    public AudioClip GenStart; //Establish Audio sources and Clips, this could probably be optimized a bit
    public AudioClip On;
    public AudioClip Off;
    public AudioClip Idling;
    public AudioSource clickOn;
    public AudioSource clickOff;
    public AudioSource idleOn;
    public AudioSource inIdle;
    public AudioSource idleEnd;
    void OnMouseDown()//When left mouse button presses down on the red switch's mesh, enact an action based on the current idle state
    {
        if (Idle == false) //If generator is off, turn on and play startup sounds
        {
            //Debug.Log("On");
            Idle = true;
            clickOn.PlayOneShot(On, 1.0f);
            inIdle.loop = true;
            StartCoroutine(playIdleSounds());
            return;
        }
        if (Idle == true) //If generator is on, okay shut off sounds and stop Audio
        {
            //Debug.Log("Off");
            Idle = false;
            clickOff.PlayOneShot(Off, 1.0f);
            inIdle.Stop();
            idleOn.Stop();
            idleEnd.Play();
            return;
        }
    }

    IEnumerator playIdleSounds() //Allows for the Idle sound to play sequentially after the startup sound
    {
        idleOn.Play();
        yield return new WaitForSeconds(4.15622f);
        if (Idle == true)
        {
            inIdle.Play();
        }
          yield break;
     }
    
}
