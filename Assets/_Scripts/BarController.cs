﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    public Transform bar;
    public Transform entity;
    public int currentValue;
    public int maxValue;

    // Start is called before the first frame update
    void Start()
    {
        currentValue = 100;
        maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(entity != null)
        {
            transform.position = entity.position + Vector3.up;
        }
    }

    public void SetValue(int new_value)
    {
        currentValue = new_value;
        bar.localScale = new Vector3(currentValue / 100.0f, 1.0f, 1.0f);

        // clamp the scale on the x axis to be zero minimum

        if (bar.localScale.x < 0)
        {
            bar.localScale = new Vector3(0.0f, 1.0f, 1.0f);
        }
    }
}
