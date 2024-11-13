using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructions : MonoBehaviour
{
    public GameObject instruction;
    void Start()
    {
        instruction.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            instruction.SetActive(false); 
        }
    }
}
