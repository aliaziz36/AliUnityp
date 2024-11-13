using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public int point = 1;
    public AudioClip pickupSound;  
    private CountdownTimer counttt;
    private void Start()
    {
        counttt = FindObjectOfType<CountdownTimer>(); 
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }
            counttt.increment_score(point);
            Destroy(gameObject);
        }
    }
}
