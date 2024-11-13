using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victoryy : MonoBehaviour
{
    private CountdownTimer timerVic;
    private void Start()
    {
        timerVic = FindObjectOfType<CountdownTimer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && timerVic != null)
        {
            timerVic.TriggerVictory();
            Destroy(gameObject);
        }
    }
}
   