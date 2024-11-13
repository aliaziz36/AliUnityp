using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    public float speed = 11f; 
    public int top = 8;
    public int bot = -8; 
    private Rigidbody2D rb;
    private float left;  
    private float right;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        gameObject.name = "hi3";
    }
    void Update()
    {
        Camera camee = Camera.main;
        float halfWidth = camee.orthographicSize *camee.aspect;
        left= camee.transform.position.x - halfWidth;
        right = camee.transform.position.x + halfWidth;
        float X = Input.GetAxis("Horizontal");  
        float Y =Input.GetAxis("Vertical");
        Vector2 news =rb.position +new Vector2((X *speed * Time.deltaTime), (Y *speed*Time.deltaTime));
        news.x= Mathf.Clamp(news.x, left, right);   
        news.y = Mathf.Clamp(news.y, bot, top);  
        rb.MovePosition(news);


        
    }
    public void boost(float duration)
    {
        StartCoroutine(booster(duration));
    }
    private IEnumerator booster(float duration)
    {
        float speedO = speed;
        speed *=2;  
        yield return new WaitForSeconds(duration);
        speed = speedO; 
    }      
}
