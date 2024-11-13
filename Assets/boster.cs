using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boster : MonoBehaviour
{
    public float boostt = 1.5f;  
    public float timeboost = 5f;      
    public AudioClip boostSound;         
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (boostSound != null)
            {
                AudioSource.PlayClipAtPoint(boostSound, transform.position);
            }
            test2 move = other.GetComponent<test2>();
            if (move != null)
            {
                move.boost(timeboost);
            }

            Destroy(gameObject);
        }
    }
}