using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onOff : MonoBehaviour
{
    public GameObject panal;
    public bool started = false;
    void Start()
    {
        panal.SetActive(true);  
        Time.timeScale = 0;  
    }
    void Update()
    {
        if (!started && Input.GetKeyDown(KeyCode.Return))
        {
            panal.SetActive(false);  
            started = true;  
            Time.timeScale = 1;  
        }
    }
}
