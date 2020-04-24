using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundController : MonoBehaviour
{
    public AudioSource source;

    [Header("Shooting sounds")]
    public AudioClip shootSound;
    public AudioClip hitSound;

    public void SoundShoot()
    {
        float randomPitch = Random.Range(0.5f, 1.5f);        
        source.clip = shootSound;
        source.pitch = randomPitch;
        source.Play();
    }
    public void SoundHit()
    {
        float randomPitch = Random.Range(0, 5) / 10 + 1;        
        source.clip = hitSound;
        source.pitch = randomPitch;
        source.Play();
    }
}
