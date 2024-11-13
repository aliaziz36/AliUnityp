using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class negative : MonoBehaviour
{
    public int scoreN = -1;
    public AudioClip musicN;
    private CountdownTimer timerN;
    void Start()
    {
        timerN = FindObjectOfType<CountdownTimer>();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (musicN != null)
            {
                AudioSource.PlayClipAtPoint(musicN, transform.position);
            }
            timerN.increment_score(scoreN);
            Destroy(gameObject);
        }
    }
}
