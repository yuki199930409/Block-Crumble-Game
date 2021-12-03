using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip[] sound;
    public AudioSource audioSource;

    public void Sound(int num)
    {
        audioSource.PlayOneShot(sound[num]);
    }
}
