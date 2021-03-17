using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip laserSound;
    static AudioSource audioSrc;

    void Start()
    {
        laserSound = Resources.Load<AudioClip>("laser");

        audioSrc = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "laser":
                audioSrc.PlayOneShot(laserSound);
                break;
        }
    }
}
