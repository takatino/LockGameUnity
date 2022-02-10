using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class rotatedot : MonoBehaviour
{
    public float r = 3;
    public double speed = 3.14;
    public float centerX = 0;
    public float centerY = 0;
    private double theta = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        theta += speed * Time.deltaTime;

        pos.x = centerX + (r * Convert.ToSingle(Math.Cos(theta)));
        pos.y = centerY + (r * Convert.ToSingle(Math.Sin(theta)));

        transform.position = pos;

    }
}
