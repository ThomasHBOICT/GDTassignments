using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public sounds sound;
    public AudioSource source;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Portal")
        {
            source.clip = sound.portal;
            source.Play();
        }
        if (collision.tag == "Enemy")
        {
            source.clip = sound.damage;
            source.Play();
        }
    }
}
