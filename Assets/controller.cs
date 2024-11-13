using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public GameObject idle;        
    public GameObject movein;      
    private Animator animator;

    void Start()
    {
        animator = movein.GetComponent<Animator>();

        idle.SetActive(true);
        movein.SetActive(false);
    }

    void Update()
    {
        bool isMoving = Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0;

        if (isMoving)
        {
            idle.SetActive(false);
            movein.SetActive(true);
            animator.SetBool("isMoving", true);
        }
        else
        {
            idle.transform.position = movein.transform.position;
            idle.SetActive(true);
            movein.SetActive(false);
            animator.SetBool("isMoving", false);
        }

        if (Input.GetKey(KeyCode.X))
        {
            ToggleObstacleColliders(false); 
        }
        else
        {
            ToggleObstacleColliders(true);   
        }
    }

    private void ToggleObstacleColliders(bool enable)
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obs");
        foreach (GameObject obstacle in obstacles)
        {
            Collider2D collider = obstacle.GetComponent<Collider2D>();
            if (collider != null)
            {
                collider.enabled = enable;
            }
        }
    }
}
