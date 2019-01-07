﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Rotation : MonoBehaviour
{

    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(transform.up, mouseX * speed * Time.deltaTime);
    }
}
