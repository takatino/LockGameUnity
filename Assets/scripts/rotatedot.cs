using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class rotatedot : MonoBehaviour
{
    public float r = 5f;
    public double speed = 5d;
    public float centerX = 0f;
    public float centerY = 0f;
    private double theta = 0d;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        theta = ((theta * 2 * Math.PI) + speed * Time.deltaTime) % (2 * Math.PI);

        pos.x = centerX + r * Convert.ToSingle(Math.Cos(theta));
        pos.y = centerY + r * Convert.ToSingle(Math.Sin(theta));

    }
}
