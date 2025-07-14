using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_run : MonoBehaviour
{
    public int Speed = 8;

    void Start()
{
    enabled = false;
}


    void Update()
    {
        transform.Translate(0, 0, Speed * Time.deltaTime);
    }
}
