using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockanimation : MonoBehaviour
{
    public bool trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger == true)
        {
            Debug.Log("test");
            trigger = false;
        }
    }
}
