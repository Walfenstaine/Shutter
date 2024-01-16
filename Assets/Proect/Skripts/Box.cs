using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Box : MonoBehaviour
{
    public static event Action stopTarget;
    public AudioClip clip;

    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("Open", true);
            SoundPlayer.regit.Play(clip,1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("Open", false);
            SoundPlayer.regit.Play(clip,1);
            stopTarget.Invoke();
        }
    }
}
