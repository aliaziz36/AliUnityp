using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramoving : MonoBehaviour
{
    public float speed = 2.4f;
    public Transform player;
    private float left;
    private onOff gameController;

    void Start()
    {
        gameController = FindObjectOfType<onOff>();
        updateLeft();
    }

    void Update()
    {
        if (gameController != null&& gameController.started)
        {
        transform.position = transform.position +(Vector3.right * speed * Time.deltaTime);
        updateLeft();
         if (player != null)
        {
            Vector3 corr = player.position;
            corr.x = Mathf.Max(corr.x, left);
            player.position = corr;
    
               }
    }
    }
    void updateLeft()
    {
        Camera camee = Camera.main;
        float halfWidth = camee.orthographicSize * camee.aspect;
        left= camee.transform.position.x - halfWidth;
    }
}
